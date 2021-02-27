Remove-Item -LiteralPath "..\src\cli\bin\Release" -Recurse -ErrorAction SilentlyContinue
Remove-Item -LiteralPath "..\src\gui\bin\Release" -Recurse -ErrorAction SilentlyContinue
Remove-Item -LiteralPath "..\src\cli\obj\Release" -Recurse -ErrorAction SilentlyContinue
Remove-Item -LiteralPath "..\src\gui\obj\Release" -Recurse -ErrorAction SilentlyContinue
Start-Process -FilePath "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" -ArgumentList ${PSScriptRoot}"\..\src\cli\SuperBLTHasherCLI.sln /t:Build /p:Configuration=Release" -NoNewWindow
Start-Process -FilePath "C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" -ArgumentList ${PSScriptRoot}"\..\src\gui\SuperBLTHasher.sln /t:Build /p:Configuration=Release" -NoNewWindow
