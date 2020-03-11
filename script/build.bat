@echo off
"%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe" "%~dp0\..\src\SuperBLTHasher.sln" /t:Build /p:Configuration=Release
pause
