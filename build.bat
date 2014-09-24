@ECHO off

CD %~dp0

MKDIR out >NUL 2>&1

csc.exe /nologo /optimize+ /unsafe- ^
  /debug+ ^
  /target:library ^
  /out:out\saklient.dll ^
  /recurse:src\*.cs ^
  /r:System.Web.Extensions.dll

