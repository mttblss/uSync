Write-Host "Copying files from source to target ..." -NoNewline
Remove-Item .\uSyncTarget.Site\uSync -Recurse -Force
Copy-Item .\uSync.Site\uSync -Destination .\uSyncTarget.Site\uSync -Recurse -Force
Copy-Item .\uSync.Site\Views -Destination .\uSyncTarget.Site -Recurse -Force
Copy-Item .\uSync.Site\wwwroot -Destination .\uSyncTarget.Site -Recurse -Force
Write-Host " Done"