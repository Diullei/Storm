echo off
css /cd ExternalAsm
css /e host.cs
copy %CSSCRIPT_DIR%\Lib\CSScriptLibrary.dll CSScriptLibrary.dll
copy %CSSCRIPT_DIR%\Lib\CSSCodeProvider.dll CSSCodeProvider.dll
host.exe

pause