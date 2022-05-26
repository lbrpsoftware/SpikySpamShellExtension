@ECHO OFF
CLS

ECHO CLEANING SOURCES

FOR /d /r . %%d IN ("bin") DO @IF EXIST "%%d" rd /s /q "%%d"
FOR /d /r . %%d IN ("obj") DO @IF EXIST "%%d" rd /s /q "%%d"

ECHO DONE 

PING -n 3 localhost > NUL


