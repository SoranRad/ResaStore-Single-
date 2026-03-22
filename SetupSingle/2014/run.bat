rem for /r %%v in (*.sql) do sqlcmd -S ".\sqlnegin" -i  "%%v"

@echo off
set loc=%cd%\Scheme.sql
sqlcmd -S".\sqlnegin" -i"%loc%"

pause
set locd=%cd%\Data_Only.sql
sqlcmd -S".\sqlnegin" -i"%locd%"
 