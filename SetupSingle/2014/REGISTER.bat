
@echo off
set loc=%cd%\Register.sql
sqlcmd -S".\sqlnegin" -i"%loc%"

pause

 
 