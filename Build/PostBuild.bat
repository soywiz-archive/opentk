cd..

rem Copying files to output directory

dir Source /s /b  | find ".exe" | find /V "build" | find /V "Examples" > exe.txt
dir Source /s /b  | find ".dll" | find /V "build" | find /V "Examples" > dll.txt
for /F "delims='" %%f in (exe.txt) do xcopy "%%f" "Binaries\Libraries\*.*" /Q /Y
for /F "delims='" %%f in (dll.txt) do xcopy "%%f" "Binaries\Libraries\*.*" /Q /Y

del exe.txt
del dll.txt

dir Source\Examples /s /b  | find ".exe" | find /V "build" > exe.txt
for /F "delims='" %%f in (dll.txt) do xcopy "%%f" "Binaries\Examples\*.*" /Q /Y

del exe.txt

cd Build