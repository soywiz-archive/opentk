echo off

cd..

Build\Prebuild /clean /yes /file Prebuild.xml

echo Cleaning intermediate object files.
dir /s /b /ad | find "obj" > del.txt
for /F "delims='" %%f in (del.txt) do rmdir /q /s "%%f"
del del.txt

echo Cleaning intermediate binary files.
dir /s /b /ad | find "bin" > del.txt
for /F "delims='" %%f in (del.txt) do rmdir /q /s "%%f"
del del.txt

echo Cleaning Binaries directory.
rmdir Binaries /S /Q

cd Build

echo on