@echo off
setlocal

REM Paths
set UNINSTALL_PROJ=..\Uninstall\Uninstall.csproj
set MAIN_PROJ=..\aol_4\aol_4.csproj
set MAIN_OUTPUT=..\aol_4\bin\Release\net8.0-Windows
set UNINSTALL_PUBLISH=..\Uninstall\bin\x64\Release\net8.0-windows\win-x64\publish\Uninstall.exe
set ICON=..\aol_4\Resources\aol_icon.ico
set ZIP_OUTPUT=assets.zip
set PAK_OUTPUT=assets.pak

REM Fallback for local testing if AppVeyor variable is not set
if "%APPVEYOR_BUILD_VERSION%"=="" set APPVEYOR_BUILD_VERSION=1.0.999.0

"C:\Program Files\dotnet\dotnet.exe" restore "%UNINSTALL_PROJ%" -r win-x64

REM Publish Uninstall.exe as single-file self-contained EXE
"C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\msbuild" "%UNINSTALL_PROJ%" /t:Publish /p:Configuration=Release /p:PublishSingleFile=true /p:SelfContained=true /p:RuntimeIdentifier=win-x64 /p:Version=%APPVEYOR_BUILD_VERSION% /p:FileVersion=%APPVEYOR_BUILD_VERSION% /p:InformationalVersion=%APPVEYOR_BUILD_VERSION%

REM Build main project
"C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\msbuild" "%MAIN_PROJ%" /p:Configuration=Release /p:Version=%APPVEYOR_BUILD_VERSION% /p:FileVersion=%APPVEYOR_BUILD_VERSION% /p:InformationalVersion=%APPVEYOR_BUILD_VERSION%

REM Remove old ZIP if exists
if exist "%ZIP_OUTPUT%" del /F "%ZIP_OUTPUT%"

REM Zip main project output
powershell -Command "Compress-Archive -Path '%MAIN_OUTPUT%\*' -DestinationPath '%ZIP_OUTPUT%' -Force"

REM Add the Uninstall.exe to the ZIP
powershell -Command "Compress-Archive -Path '%UNINSTALL_PUBLISH%' -Update -DestinationPath '%ZIP_OUTPUT%'"

powershell -Command "Compress-Archive -Path '%ICON%' -Update -DestinationPath '%ZIP_OUTPUT%'"

REM Rename to .pak
move /Y "%ZIP_OUTPUT%" "%PAK_OUTPUT%"

endlocal
