# ================================================================
# SmartLibrarySystem - MSI installer build script (Windows only)
#
# Usage:
#   1. Open the solution in Visual Studio 2019 and build the
#      "Release" configuration (menu: Build -> Configuration Manager
#      -> change to Release, then Build -> Build Solution).
#   2. Run this script in PowerShell:
#        .\Installer\Build-MSI.ps1
#
# The resulting installer is written to:
#     SmartLibrarySystem\SmartLibrarySystem.msi
#
# The installer uses the WiX Toolset v4 (installed automatically as a
# local dotnet tool in .\Installer\tools - no admin rights needed).
# ================================================================
param(
    [string]$WixVersion = "4.0.5",
    [string]$Arch = "x86"
)

$ErrorActionPreference = "Stop"

$root = Split-Path -Parent $MyInvocation.MyCommand.Path
Set-Location $root

Write-Host "== SmartLibrarySystem MSI build ==" -ForegroundColor Cyan
Write-Host "WixVersion: $WixVersion"
Write-Host "Arch      : $Arch"

# 1. Make sure the Release build output exists.
$releaseFolder = Join-Path $root "..\bin\Release"
if (-not (Test-Path (Join-Path $releaseFolder "SmartLibrarySystem.exe"))) {
    throw "Release build output not found at '$releaseFolder'. Build the solution in Release mode first."
}
Write-Host "Using build output: $releaseFolder"

# 2. Install (or reuse) the WiX Toolset as a local dotnet tool.
$wixExe = Join-Path $root "tools\wix\wix.exe"
if (-not (Test-Path $wixExe)) {
    Write-Host "Installing WiX Toolset v$WixVersion (local tool)..." -ForegroundColor Yellow
    dotnet tool install --tool-path (Join-Path $root "tools\wix") wix --version $WixVersion
}

# 3. Build the MSI.
$outMsi = Join-Path $root "..\..\SmartLibrarySystem.msi"
Write-Host "Building MSI: $outMsi"
& $wixExe build "SmartLibrarySystem.wxs" -arch $Arch -out $outMsi -bindpath $releaseFolder
if ($LASTEXITCODE -ne 0) {
    throw "WiX build failed with exit code $LASTEXITCODE"
}

Write-Host ""
Write-Host "SUCCESS: installer created at $outMsi" -ForegroundColor Green