@ECHO off

CD %~dp0
CALL config.bat

IF EXIST packages GOTO RESTORE_NUGET
nuget.exe install
IF %ERRORLEVEL% NEQ 0 EXIT /b %ERRORLEVEL%
:RESTORE_NUGET
nuget.exe restore
IF %ERRORLEVEL% NEQ 0 EXIT /b %ERRORLEVEL%

FOR /F "usebackq" %%w IN (`DIR /s /b Tamir.SharpSSH.dll`) DO SET SHARPSSH=%%w
FOR /F "usebackq" %%w IN (`DIR /s /b DiffieHellman.dll`) DO SET DIFFIEHELLMAN=%%w
FOR /F "usebackq" %%w IN (`DIR /s /b Org.Mentalis.Security.dll`) DO SET MENTALIS_SECURITY=%%w
FOR /F "usebackq" %%w IN (`DIR /s /b nunit.framework.dll`) DO SET NUNIT_FRAMEWORK=%%w
FOR /F "usebackq" %%w IN (`DIR /s /b nunit-console.exe`) DO SET NUNIT_CONSOLE=%%w

csc.exe /nologo /optimize+ /unsafe- ^
  /debug+ ^
  /target:library ^
  /out:out\tests.dll ^
  /recurse:tests\*.cs ^
  /r:out\saklient.dll ^
  /r:%SHARPSSH% ^
  /r:%DIFFIEHELLMAN% ^
  /r:%MENTALIS_SECURITY% ^
  /r:%NUNIT_FRAMEWORK%
IF %ERRORLEVEL% NEQ 0 EXIT /b %ERRORLEVEL%

COPY /y %SHARPSSH% out\
COPY /y %DIFFIEHELLMAN% out\
COPY /y %MENTALIS_SECURITY% out\
COPY /y %NUNIT_FRAMEWORK% out\

%NUNIT_CONSOLE% out\tests.dll %*
IF %ERRORLEVEL% NEQ 0 EXIT /b %ERRORLEVEL%

nuget.exe pack
