$7Zip = ${env:ProgramFiles} + "\7-Zip\7z.exe"

# Create the release folder if it doesn't exist
if (-not (Test-Path -Path ".\.release")) {
	New-Item -Path ".\.release" -ItemType Directory -ErrorAction Stop | Out-Null
}

# Copy compiled binaries and other files inside the release folder
if ((Test-Path -LiteralPath ".\src\cli\bin\Release\netcoreapp3.1\SuperBLTHasherCLI.exe") -And (Test-Path -LiteralPath ".\src\gui\bin\Release\SuperBLTHasher.exe")) {
	Write-Host "Copying compiled binaries and other files."
	Copy-Item -LiteralPath ".\src\cli\bin\Release\netcoreapp3.1\SuperBLTHasherCLI.exe" -Destination ".\.release\superblthasher-cli.exe" -Force
	Copy-Item -LiteralPath ".\src\gui\bin\Release\SuperBLTHasher.exe" -Destination ".\.release\SuperBLT Hasher.exe" -Force
	Copy-Item -LiteralPath ".\src\cli\HashLib.dll" -Destination ".\.release\HashLib.dll" -Force
	Copy-Item -Path ".\src\gui\Licenses" -Destination ".\.release\" -Recurse -Force
	Copy-Item -LiteralPath ".\CHANGELOG.txt" -Destination ".\.release\CHANGELOG.txt" -Force

	# Create release archive
	Write-Host "Creating release archive."
	Remove-Item ".\.release\*.7z" -ErrorAction SilentlyContinue # Remove old release archive to avoid adding it in the new archive
	Start-Process -FilePath ${7zip} -WorkingDirectory ".\.release" -ArgumentList "a -t7z SuperBLTHasher_release.7z .\*" -NoNewWindow
}
else {
	Write-Warning "SuperBLT Hasher binaries not found. Compile it first!"
}
