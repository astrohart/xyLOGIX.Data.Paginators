@echo on
if exist "C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Data.Paginators\xyLOGIX.Data.Paginators.Events\bin\x64\Debug\xyLOGIX.Data.Paginators.Events.md" (
    if exist "C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Data.Paginators\xyLOGIX.Data.Paginators.Events\README.md" (
        erase /F /Q "C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Data.Paginators\xyLOGIX.Data.Paginators.Events\README.md"
    )
    copy /Y "C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Data.Paginators\xyLOGIX.Data.Paginators.Events\bin\x64\Debug\xyLOGIX.Data.Paginators.Events.md" "C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Data.Paginators\xyLOGIX.Data.Paginators.Events\README.md"
    git config core.autocrlf true
    git add .
    git commit -a -m "Update README.md"
    git push -u origin master
)
exit /b 0