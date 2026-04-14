rem for /r %%v in (*.sql) do sqlcmd -S ".\sqlnegin" -i  "%%v"

@echo off
set loc=%cd%\Schema.sql
sqlcmd -S".\sqlresa" -i"%loc%"

pause
set locd=%cd%\Data_Only.sql
sqlcmd -S".\sqlresa" -i"%locd%"
 