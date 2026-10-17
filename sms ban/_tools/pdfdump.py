import re, sys, zlib
p = sys.argv[1]
data = open(p,'rb').read()
print("size", len(data))
print("header", data[:20])
# count objects
objs = re.findall(rb'(\d+)\s+(\d+)\s+obj', data)
print("num obj tokens", len(objs))
# find stream filters
for m in re.finditer(rb'/(Filter|Subtype)\s*/?(\w+)', data):
    pass
from collections import Counter
c = Counter(re.findall(rb'/Filter\s*(\[[^\]]*\]|/\w+)', data))
print("filters:", c.most_common(20))
c2 = Counter(re.findall(rb'/Subtype\s*/(\w+)', data))
print("subtypes:", c2.most_common(20))
c3 = Counter(re.findall(rb'/Type\s*/(\w+)', data))
print("types:", c3.most_common(20))
print("Encrypt present:", b'/Encrypt' in data)
print("ToUnicode count:", len(re.findall(rb'/ToUnicode', data)))
print("FontFile:", len(re.findall(rb'/FontFile\d?', data)))
print("Pages count token:", re.findall(rb'/Count\s+(\d+)', data)[:10])
print("Producer:", re.findall(rb'/Producer\s*\(([^)]*)\)', data)[:3])
print("Creator:", re.findall(rb'/Creator\s*\(([^)]*)\)', data)[:3])
