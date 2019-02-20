rem SET QUSER=BCircle.ServiceInstaller.Web.exe

SET QNAME=BCircle.ServiceInstaller.Web.exe
SET QPASSWORD=
SET QAPP=ServiceInstaller.Web.exe
SET QPATH=%cd%
SET QHOST=%COMPUTERNAME%

rem net user %QUSER% %QPASSWORD% /add
rem icacls "%QPATH%" /grant %QUSER%:(OI)(CI)WRX /t
sc create %QNAME% binPath= "%QPATH%\%QAPP% --urls=http://*:9000" obj= ".\LocalSystem" password= "%QPASSWORD%"
sc start %QNAME%