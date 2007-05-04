cd..

Build\Clean.bat

echo Cleaning .svn directories.
dir /s /b /ad | find ".svn" > del.txt
for /F "delims='" %%f in (del.txt) do rmdir /q /s "%%f"
del del.txt

cd Build