wmic cpu get ProcessorId  

wmic baseboard get serialnumber

pause

Get-WmiObject win32_bios | select Serialnumber

Get-WmiObject win32_processor | select serialnumber