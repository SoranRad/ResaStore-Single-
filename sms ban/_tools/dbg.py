import sys, re, zlib, runpy, io, contextlib
sys.argv = ['pdftext2.py', r'E:\_Workspace_Project_\_ResaStore_Single_\sms ban\SMSBANHelp.pdf', 'NUL', 'none', 'norev']
buf = io.StringIO()
with contextlib.redirect_stdout(buf):
    g = runpy.run_path(r'E:\_Workspace_Project_\_ResaStore_Single_\sms ban\_tools\pdftext2.py')
items = g['extract_items'](g['pages'][0])
ys = sorted({round(y) for x, y, t in items}, reverse=True)
print("distinct y:", ys[:8])
target = ys[1] if len(ys) > 1 else ys[0]
print("--- runs at y =", target, "---")
for i, (x, y, t) in enumerate(items):
    if round(y) == target:
        print("%3d  x=%8.2f  %r  %s" % (i, x, t, t.encode('unicode_escape').decode()))
