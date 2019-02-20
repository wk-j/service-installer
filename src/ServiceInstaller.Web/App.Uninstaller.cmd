rem SET QUSER=BCircle.ServiceInstaller.Web.exe
SET QNAME=BCircle.ServiceInstaller.Web.exe

sc stop   %QNAME%
sc delete %QNAME%
rem net user  %QUSER% /delete