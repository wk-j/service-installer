SET QUSER=BCircle.ConsoleApp.exe
SET QNAME=BCircle.ConsoleApp.exe

sc stop   %QNAME%
sc delete %QNAME%
net user  %QUSER% /delete