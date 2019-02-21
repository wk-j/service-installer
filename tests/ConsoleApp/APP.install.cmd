SET QUSER=BCircle.ConsoleApp.exe
SET QNAME=BCircle.ConsoleApp.exe
SET QPASSWORD=123456
SET QAPP=ConsoleApp.exe
SET QPATH=%cd%
SET QHOST=%COMPUTERNAME%

net user %QUSER% %QPASSWORD% /add
icacls "%QPATH%" /grant %QUSER%:(OI)(CI)WRX /t
sc create %QNAME% binPath= "%QPATH%\%QAPP% --urls=http://*:9000" obj= ".\LocalSystem" password= "%QPASSWORD%"
sc start %QNAME%