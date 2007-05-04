echo off

cd..

Build\Prebuild /clean /yes /file Prebuild.xml

echo Cleaning intermediate object files.
dir /s /b /ad | find "obj" > del.txt
for /F "delims='" %%f in (del.txt) do rmdir /q /s "%%f"
del del.txt

echo Cleaning binaries.
rd Binaries /S /Q

cd Build

echo on