import re, sys, zlib

PATH = sys.argv[1]
data = open(PATH, 'rb').read()

# ---------- helpers ----------
def inflate(b):
    for f in (zlib.decompress,):
        try:
            return f(b)
        except Exception:
            pass
    try:
        d = zlib.decompressobj()
        return d.decompress(b)
    except Exception:
        pass
    try:
        return zlib.decompressobj(-15).decompress(b)
    except Exception:
        return None

objs = {}          # num -> (dict_bytes, stream_bytes or None)
stream_raw = {}    # num -> raw stream bytes (still encoded)

obj_re = re.compile(rb'(?<![0-9])(\d+)\s+(\d+)\s+obj\b')
matches = list(obj_re.finditer(data))
for i, m in enumerate(matches):
    num = int(m.group(1))
    start = m.end()
    end = matches[i+1].start() if i+1 < len(matches) else len(data)
    chunk = data[start:end]
    s = chunk.find(b'stream')
    if s != -1:
        head = chunk[:s]
        # skip stream line break
        p = s + 6
        if chunk[p:p+2] == b'\r\n': p += 2
        elif chunk[p:p+1] in (b'\n', b'\r'): p += 1
        e = chunk.rfind(b'endstream')
        raw = chunk[p:e] if e != -1 else chunk[p:]
        objs[num] = norm_head = head
        stream_raw[num] = raw
    else:
        objs[num] = chunk

def decode_stream(num):
    raw = stream_raw.get(num)
    if raw is None: return None
    head = objs.get(num, b'')
    if b'/FlateDecode' in head:
        return inflate(raw)
    return raw

# ---------- expand object streams ----------
expanded = {}
for num, head in list(objs.items()):
    if b'/ObjStm' in head:
        dec = decode_stream(num)
        if dec is None: continue
        mN = re.search(rb'/N\s+(\d+)', head); mF = re.search(rb'/First\s+(\d+)', head)
        if not (mN and mF): continue
        N = int(mN.group(1)); First = int(mF.group(1))
        header = dec[:First]
        nums = re.findall(rb'(\d+)\s+(\d+)', header)
        for k in range(N):
            onum = int(nums[k][0]); off = int(nums[k][1])
            nxt = int(nums[k+1][1]) if k+1 < N else len(dec) - First
            body = dec[First+off: First+nxt]
            expanded[onum] = body

for k, v in expanded.items():
    if k not in objs:
        objs[k] = v

def get(num):
    return objs.get(num)

def deref(tok):
    m = re.match(rb'\s*(\d+)\s+\d+\s+R', tok)
    return int(m.group(1)) if m else None

# ---------- find pages in order ----------
def find_pages():
    # locate catalog
    cat = None
    for n, b in objs.items():
        if b'/Type' in b and b'/Catalog' in b:
            cat = n; break
    pages_root = None
    if cat is not None:
        m = re.search(rb'/Pages\s+(\d+)\s+\d+\s+R', objs[cat])
        if m: pages_root = int(m.group(1))
    ordered = []
    def walk(n, depth=0):
        if depth > 12: return
        b = objs.get(n)
        if b is None: return
        if b'/Type' in b and re.search(rb'/Type\s*/Page\b', b):
            ordered.append(n); return
        m = re.search(rb'/Kids\s*\[(.*?)\]', b, re.S)
        if m:
            for kid in re.findall(rb'(\d+)\s+\d+\s+R', m.group(1)):
                walk(int(kid), depth+1)
        else:
            # maybe /Kids via indirect
            m2 = re.search(rb'/Kids\s+(\d+)\s+\d+\s+R', b)
            if m2:
                kb = objs.get(int(m2.group(1)), b'')
                for kid in re.findall(rb'(\d+)\s+\d+\s+R', kb):
                    walk(int(kid), depth+1)
    if pages_root is not None:
        walk(pages_root)
    if not ordered:
        ordered = [n for n, b in objs.items() if re.search(rb'/Type\s*/Page\b', b)]
        ordered.sort()
    return ordered

pages = find_pages()

# ---------- ToUnicode CMaps ----------
def parse_cmap(txt):
    mp = {}
    for blk in re.findall(rb'beginbfchar(.*?)endbfchar', txt, re.S):
        for src, dst in re.findall(rb'<([0-9A-Fa-f]+)>\s*<([0-9A-Fa-f]+)>', blk):
            code = int(src, 16)
            s = bytes.fromhex(dst.decode()).decode('utf-16-be', 'replace')
            mp[code] = s
    for blk in re.findall(rb'beginbfrange(.*?)endbfrange', txt, re.S):
        # <lo> <hi> <dst>
        for lo, hi, dst in re.findall(rb'<([0-9A-Fa-f]+)>\s*<([0-9A-Fa-f]+)>\s*<([0-9A-Fa-f]+)>', blk):
            l, h = int(lo, 16), int(hi, 16)
            base = int(dst, 16)
            for i in range(h - l + 1):
                try:
                    mp[l+i] = chr(base + i)
                except Exception:
                    pass
        # <lo> <hi> [ <d1> <d2> ... ]
        for lo, hi, arr in re.findall(rb'<([0-9A-Fa-f]+)>\s*<([0-9A-Fa-f]+)>\s*\[(.*?)\]', blk, re.S):
            l = int(lo, 16)
            items = re.findall(rb'<([0-9A-Fa-f]+)>', arr)
            for i, it in enumerate(items):
                mp[l+i] = bytes.fromhex(it.decode()).decode('utf-16-be', 'replace')
    return mp

cmap_cache = {}
def get_cmap(num):
    if num in cmap_cache: return cmap_cache[num]
    dec = decode_stream(num)
    r = parse_cmap(dec) if dec else {}
    cmap_cache[num] = r
    return r

# ---------- font resolution per page ----------
def page_fonts(page_num):
    b = objs.get(page_num, b'')
    fonts = {}
    res = b
    m = re.search(rb'/Resources\s+(\d+)\s+\d+\s+R', b)
    if m:
        res = objs.get(int(m.group(1)), b'')
    mf = re.search(rb'/Font\s*<<(.*?)>>', res, re.S)
    if not mf:
        mf2 = re.search(rb'/Font\s+(\d+)\s+\d+\s+R', res)
        if mf2:
            fb = objs.get(int(mf2.group(1)), b'')
            mf = re.search(rb'<<(.*?)>>', fb, re.S)
    if mf:
        for name, onum in re.findall(rb'/([A-Za-z0-9#+._-]+)\s+(\d+)\s+\d+\s+R', mf.group(1)):
            fd = objs.get(int(onum), b'')
            tu = re.search(rb'/ToUnicode\s+(\d+)\s+\d+\s+R', fd)
            two = bool(re.search(rb'/Subtype\s*/Type0', fd))
            fonts[name.decode()] = (get_cmap(int(tu.group(1))) if tu else None, two)
    return fonts

# ---------- content stream text extraction ----------
def unescape_literal(s):
    out = bytearray(); i = 0
    while i < len(s):
        c = s[i]
        if c == 0x5C and i+1 < len(s):
            n = s[i+1]
            mp = {0x6E:10, 0x72:13, 0x74:9, 0x62:8, 0x66:12, 0x28:0x28, 0x29:0x29, 0x5C:0x5C}
            if n in mp: out.append(mp[n]); i += 2; continue
            if 0x30 <= n <= 0x37:
                oct_s = b''
                j = i+1
                while j < len(s) and len(oct_s) < 3 and 0x30 <= s[j] <= 0x37:
                    oct_s += bytes([s[j]]); j += 1
                out.append(int(oct_s, 8) & 0xFF); i = j; continue
            out.append(n); i += 2; continue
        out.append(c); i += 1
    return bytes(out)

def decode_text(raw, fonts, cur_font):
    cmap, two = fonts.get(cur_font, (None, False))
    if two or (cmap and max(cmap.keys(), default=0) > 255):
        codes = [int.from_bytes(raw[i:i+2], 'big') for i in range(0, len(raw)-1, 2)]
    else:
        codes = list(raw)
    if cmap:
        return ''.join(cmap.get(c, '') for c in codes)
    return ''.join(chr(c) for c in codes)

def extract_page(page_num):
    b = objs.get(page_num, b'')
    fonts = page_fonts(page_num)
    content = b''
    m = re.search(rb'/Contents\s+(\d+)\s+\d+\s+R', b)
    if m:
        content = decode_stream(int(m.group(1))) or b''
    else:
        m = re.search(rb'/Contents\s*\[(.*?)\]', b, re.S)
        if m:
            for c in re.findall(rb'(\d+)\s+\d+\s+R', m.group(1)):
                content += (decode_stream(int(c)) or b'') + b'\n'
    if not content:
        return ''
    out = []
    cur_font = None
    # tokenize show operators
    token_re = re.compile(
        rb"/([A-Za-z0-9+._-]+)\s+[\d.]+\s+Tf"
        rb"|\(((?:[^()\\]|\\.)*)\)"
        rb"|<([0-9A-Fa-f\s]*)>"
        rb"|(TJ|Tj|Td|TD|T\*|ET|BT|'|\")",
        re.S)
    for m in token_re.finditer(content):
        if m.group(1):
            cur_font = m.group(1).decode(); continue
        if m.group(2) is not None:
            out.append(decode_text(unescape_literal(m.group(2)), fonts, cur_font)); continue
        if m.group(3) is not None:
            hx = re.sub(rb'\s', b'', m.group(3))
            if len(hx) % 2: hx += b'0'
            try:
                out.append(decode_text(bytes.fromhex(hx.decode()), fonts, cur_font))
            except Exception:
                pass
            continue
        op = m.group(4)
        if op in (b'Td', b'TD', b'T*', b"'", b'"', b'ET'):
            out.append('\n')
    txt = ''.join(out)
    txt = re.sub(r'\n{2,}', '\n', txt)
    return txt

result = []
for i, p in enumerate(pages, 1):
    t = extract_page(p)
    result.append('===== PAGE %d (obj %d) =====\n%s' % (i, p, t))

open(sys.argv[2], 'w', encoding='utf-8').write('\n'.join(result))
print("pages:", len(pages))
print("wrote", sys.argv[2])
