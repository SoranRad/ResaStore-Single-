@echo off
setlocal

set "sourceFile=DorsanDesk.exe"

set "destinationFolder=%LocalAppData%\DorsanDesk"

if not exist "%destinationFolder%" mkdir "%destinationFolder%"

copy ".\*" "%destinationFolder%"

REM Create a desktop shortcut
set "shortcutName=DorsanDesk.lnk"
set "shortcutTarget=%destinationFolder%\%sourceFile%"
set "desktopFolder=%UserProfile%\Desktop"

where powershell > nul 2>&1

IF ERRORLEVEL 0 GOTO powerShell

    echo Set oWS = WScript.CreateObject("WScript.Shell")>CreateShortcut.vbs
    echo sLinkFile = "%desktopFolder%\%shortcutName%">>CreateShortcut.vbs
    echo Set oLink = oWS.CreateShortcut(sLinkFile)>>CreateShortcut.vbs
    echo oLink.TargetPath = "%shortcutTarget%">>CreateShortcut.vbs
    echo oLink.Save>>CreateShortcut.vbs

    cscript /nologo CreateShortcut.vbs
    del CreateShortcut.vbs
    echo Desktop shortcut created using VBS.
	
GOTO finish
:powerShell

	powershell -Command "$sh = (New-Object -ComObject WScript.Shell).CreateShortcut('%desktopFolder%\%shortcutName%'); $sh.TargetPath = '%shortcutTarget%'; $sh.Save()"
	echo Desktop shortcut created using PowerShell.

:finish
echo Installation completed.
pause