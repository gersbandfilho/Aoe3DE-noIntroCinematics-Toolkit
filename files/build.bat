@echo off
echo Building ResolutionSwitcher...
dotnet publish ResolutionSwitcher.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o publish
if errorlevel 1 (
  echo.
  echo BUILD FAILED. Make sure .NET 8 SDK is installed.
  pause
  exit /b 1
)
echo.
echo Done! Your EXE is:
echo publish\ResolutionSwitcher.exe
pause
