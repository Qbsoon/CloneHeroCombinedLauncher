@echo off
setlocal

rem x64
dotnet publish -c Release -r win-x64 --self-contained -p:PublishSingleFile=true -p:AssemblyName=CloneHeroCombinedLauncher-64bit

rem x86
dotnet publish -c Release -r win-x86 --self-contained -p:PublishSingleFile=true -p:AssemblyName=CloneHeroCombinedLauncher-32bit

echo Done
endlocal
pause

