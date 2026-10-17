import re, sys, zlib, unicodedata

PATH, OUT = sys.argv[1], sys.argv[2]
data = open(PATH, 'rb').read()

def inflate(b):
    try: return zlib.decompress(b)
    except Exception: pass
    try: return zlib.decompressobj().decompress(b)
    except Exception: pass
    try: return zlib.decompressobj(-15).decompress(b)
    except Exception: return None

objs, stream_raw = {}, {}
obj_re = re.compile(rb'(?<![0-9])(\d+)\s+(\d+)\s+obj\b')
matches = list(obj_re.finditer(data))
for i, m in enumerate(matches):
    num = int(m.group(1)); start = m.end()
    end = matches[i+1].start() if i+1 < len(matches) else len(data)
    chunk = data[start:end]
    s = chunk.find(b'stream')
    if s != -1:
        objs[num] = chunk[:s]
        p = s + 6
        if chunk[p:p+2] == b'\r\n': p += 2
        elif chunk[p:p+1] in (b'\n', b'\r'): p += 1
        e = chunk.rfind(b'endstream')
        stream_raw[num] = chunk[p:e] if e != -1 else chunk[p:]
    else:
        objs[num] = chunk

def decode_stream(num):
    raw = stream_raw.get(num)
    if raw is None: return None
    return inflate(raw) if b'/FlateDecode' in objs.get(num, b'') else raw

for num, head in list(objs.items()):
    if b'/ObjStm' in head:
        dec = decode_stream(num)
        if dec is None: continue
        mN = re.search(rb'/N\s+(\d+)', head); mF = re.search(rb'/First\s+(\d+)', head)
        if not (mN and mF): continue
        N, First = int(mN.group(1)), int(mF.group(1))
        nums = re.findall(rb'(\d+)\s+(\d+)', dec[:First])
        for k in range(N):
            onum, off = int(nums[k][0]), int(nums[k][1])
            nxt = int(nums[k+1][1]) if k+1 < N else len(dec) - First
            if onum not in objs:
                objs[onum] = dec[First+off: First+nxt]

def find_pages():
    cat = next((n for n, b in objs.items() if b'/Catalog' in b), None)
    root = None
    if cat is not None:
        m = re.search(rb'/Pages\s+(\d+)\s+\d+\s+R', objs[cat])
        if m: root = int(m.group(1))
    ordered = []
    def walk(n, d=0):
        if d > 12: return
        b = objs.get(n)
        if b is None: return
        if re.search(rb'/Type\s*/Page\b', b): ordered.append(n); return
        m = re.search(rb'/Kids\s*\[(.*?)\]', b, re.S)
        if m:
            for kid in re.findall(rb'(\d+)\s+\d+\s+R', m.group(1)): walk(int(kid), d+1)
    if root: walk(root)
    if not ordered:
        ordered = sorted(n for n, b in objs.items() if re.search(rb'/Type\s*/Page\b', b))
    return ordered

pages = find_pages()

def parse_cmap(txt):
    mp = {}
    for blk in re.findall(rb'beginbfchar(.*?)endbfchar', txt, re.S):
        for src, dst in re.findall(rb'<([0-9A-Fa-f]+)>\s*<([0-9A-Fa-f]+)>', blk):
            mp[int(src, 16)] = bytes.fromhex(dst.decode()).decode('utf-16-be', 'replace')
    for blk in re.findall(rb'beginbfrange(.*?)endbfrange', txt, re.S):
        for lo, hi, dst in re.findall(rb'<([0-9A-Fa-f]+)>\s*<([0-9A-Fa-f]+)>\s*<([0-9A-Fa-f]+)>', blk):
            l, h, base = int(lo,16), int(hi,16), int(dst,16)
            for i in range(h-l+1):
                try: mp[l+i] = chr(base+i)
                except Exception: pass
        for lo, hi, arr in re.findall(rb'<([0-9A-Fa-f]+)>\s*<([0-9A-Fa-f]+)>\s*\[(.*?)\]', blk, re.S):
            l = int(lo,16)
            for i, it in enumerate(re.findall(rb'<([0-9A-Fa-f]+)>', arr)):
                mp[l+i] = bytes.fromhex(it.decode()).decode('utf-16-be', 'replace')
    return mp

cmap_cache = {}
def get_cmap(num):
    if num not in cmap_cache:
        dec = decode_stream(num)
        cmap_cache[num] = parse_cmap(dec) if dec else {}
    return cmap_cache[num]

def page_fonts(page_num):
    b = objs.get(page_num, b''); res = b
    m = re.search(rb'/Resources\s+(\d+)\s+\d+\s+R', b)
    if m: res = objs.get(int(m.group(1)), b'')
    mf = re.search(rb'/Font\s*<<(.*?)>>', res, re.S)
    if not mf:
        mf2 = re.search(rb'/Font\s+(\d+)\s+\d+\s+R', res)
        if mf2:
            mf = re.search(rb'<<(.*?)>>', objs.get(int(mf2.group(1)), b''), re.S)
    fonts = {}
    if mf:
        for name, onum in re.findall(rb'/([A-Za-z0-9+._-]+)\s+(\d+)\s+\d+\s+R', mf.group(1)):
            fd = objs.get(int(onum), b'')
            tu = re.search(rb'/ToUnicode\s+(\d+)\s+\d+\s+R', fd)
            two = bool(re.search(rb'/Subtype\s*/Type0', fd))
            fonts[name.decode()] = (get_cmap(int(tu.group(1))) if tu else None, two)
    return fonts

def unescape_literal(s):
    out = bytearray(); i = 0
    mp = {0x6E:10, 0x72:13, 0x74:9, 0x62:8, 0x66:12, 0x28:0x28, 0x29:0x29, 0x5C:0x5C}
    while i < len(s):
        c = s[i]
        if c == 0x5C and i+1 < len(s):
            n = s[i+1]
            if n in mp: out.append(mp[n]); i += 2; continue
            if 0x30 <= n <= 0x37:
                o = b''; j = i+1
                while j < len(s) and len(o) < 3 and 0x30 <= s[j] <= 0x37: o += bytes([s[j]]); j += 1
                out.append(int(o, 8) & 0xFF); i = j; continue
            out.append(n); i += 2; continue
        out.append(c); i += 1
    return bytes(out)

def decode_text(raw, fonts, cur_font):
    cmap, two = fonts.get(cur_font, (None, False))
    if two:
        codes = [int.from_bytes(raw[i:i+2], 'big') for i in range(0, len(raw)-1, 2)]
    else:
        codes = list(raw)
    if cmap: return ''.join(cmap.get(c, '') for c in codes)
    return ''.join(chr(c) for c in codes)

TOKEN = re.compile(
    rb"/([A-Za-z0-9+._-]+)\s+([\d.]+)\s+Tf"
    rb"|([-\d.]+)\s+([-\d.]+)\s+([-\d.]+)\s+([-\d.]+)\s+([-\d.]+)\s+([-\d.]+)\s+Tm"
    rb"|([-\d.]+)\s+([-\d.]+)\s+(Td|TD)"
    rb"|(T\*)"
    rb"|\(((?:[^()\\]|\\.)*)\)"
    rb"|<([0-9A-Fa-f\s]*)>"
    rb"|(TJ|Tj|'|\")",
    re.S)

def extract_items(page_num):
    b = objs.get(page_num, b'')
    fonts = page_fonts(page_num)
    content = b''
    m = re.search(rb'/Contents\s+(\d+)\s+\d+\s+R', b)
    if m: content = decode_stream(int(m.group(1))) or b''
    else:
        m = re.search(rb'/Contents\s*\[(.*?)\]', b, re.S)
        if m:
            for c in re.findall(rb'(\d+)\s+\d+\s+R', m.group(1)):
                content += (decode_stream(int(c)) or b'') + b'\n'
    if not content: return []
    items = []
    x = y = 0.0; cur_font = None; size = 10.0
    pending_break = False
    for m in TOKEN.finditer(content):
        g = m.groups()
        if g[0] is not None:
            cur_font = g[0].decode(); size = float(g[1]); continue
        if g[2] is not None:
            x = float(g[6]); y = float(g[7]); continue
        if g[8] is not None:
            tx, ty = float(g[8]), float(g[9])
            x += tx; y += ty
            continue
        if m.group(12) is not None or m.group(15) in (b"'", b'"'):
            y -= size * 1.2
            continue
        txt = None
        if m.group(13) is not None:
            txt = decode_text(unescape_literal(m.group(13)), fonts, cur_font)
        elif m.group(14) is not None:
            hx = re.sub(rb'\s', b'', m.group(14))
            if len(hx) % 2: hx += b'0'
            try: txt = decode_text(bytes.fromhex(hx.decode()), fonts, cur_font)
            except Exception: txt = None
        if txt:
            items.append([x, y, txt])
    return items

PERSIAN = re.compile(r'[\u0600-\u06FF\uFB50-\uFDFF\uFE70-\uFEFF]')
LATIN = re.compile(r'[A-Za-z0-9]')

def fix_visual(s):
    """Reverse RTL runs that are stored in visual order."""
    out = []
    for run in re.split(r'(\s+)', s):
        if not run: continue
        if PERSIAN.search(run) and not LATIN.search(run):
            out.append(run[::-1])
        else:
            out.append(run)
    return ''.join(out)

def render(items):
    """Runs are emitted in RTL logical order; runs sharing an x form one word
    whose glyphs are stored in visual (reversed) order."""
    if not items: return ''
    # group runs into lines by y proximity
    lines = []
    for x, y, t in sorted(items, key=lambda r: -r[1]):
        if lines and abs(lines[-1][0] - y) < 3:
            lines[-1][1].append((x, t))
        else:
            lines.append([y, [(x, t)]])
    out = []
    for y, runs in lines:
        # merge consecutive runs sharing (nearly) the same x into one word
        words = []
        for x, t in runs:
            if words and abs(words[-1][1] - x) < 1.5:
                words[-1][0] += t
            else:
                words.append([t, x])
        parts = []
        prev_x = None
        for text, x in words:
            if prev_x is not None and abs(prev_x - x) > 1.5:
                if parts and parts[-1].strip() and text.strip():
                    parts.append(' ')
            prev_x = x
            parts.append(fix_visual(text))
        out.append(''.join(parts).strip())
    return '\n'.join(out)

res = []
for i, p in enumerate(pages, 1):
    res.append('===== PAGE %d =====\n%s' % (i, render(extract_items(p))))

open(OUT, 'w', encoding='utf-8').write('\n\n'.join(res))
print("pages:", len(pages), "->", OUT)
