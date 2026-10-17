import struct, sys

def exports(path):
    d = open(path, 'rb').read()
    e_lfanew = struct.unpack_from('<I', d, 0x3C)[0]
    assert d[e_lfanew:e_lfanew+4] == b'PE\0\0', 'not PE'
    coff = e_lfanew + 4
    machine, nsec = struct.unpack_from('<HH', d, coff)
    opt_size = struct.unpack_from('<H', d, coff + 16)[0]
    opt = coff + 20
    magic = struct.unpack_from('<H', d, opt)[0]
    pe32plus = (magic == 0x20b)
    dd_off = opt + (112 if pe32plus else 96)
    exp_rva, exp_size = struct.unpack_from('<II', d, dd_off)
    secs = []
    so = opt + opt_size
    for i in range(nsec):
        b = so + i*40
        name = d[b:b+8].rstrip(b'\0').decode('latin1')
        vsize, vaddr, rawsize, rawptr = struct.unpack_from('<IIII', d, b+8)
        secs.append((vaddr, vsize, rawptr, rawsize, name))
    def r2o(rva):
        for vaddr, vsize, rawptr, rawsize, name in secs:
            if vaddr <= rva < vaddr + max(vsize, rawsize):
                return rawptr + (rva - vaddr)
        return None
    if not exp_rva: return machine, pe32plus, []
    eo = r2o(exp_rva)
    nfun, nnam = struct.unpack_from('<II', d, eo + 20)
    addr_names = struct.unpack_from('<I', d, eo + 32)[0]
    no = r2o(addr_names)
    names = []
    for i in range(nnam):
        nr = struct.unpack_from('<I', d, no + i*4)[0]
        o = r2o(nr)
        end = d.index(b'\0', o)
        names.append(d[o:end].decode('latin1'))
    return machine, pe32plus, sorted(names)

for p in sys.argv[1:]:
    try:
        m, p64, names = exports(p)
        arch = {0x14c:'x86', 0x8664:'x64'}.get(m, hex(m))
        print("=== %s  [%s, PE32+=%s]  %d exports ===" % (p, arch, p64, len(names)))
        for n in names: print("   ", n)
    except Exception as ex:
        print("=== %s  ERROR %s" % (p, ex))
