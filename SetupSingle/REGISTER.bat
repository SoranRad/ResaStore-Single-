
@echo off
set loc=%cd%\Register.sql
sqlcmd -S".\sqlresa" -i"%loc%"

pause

 
 