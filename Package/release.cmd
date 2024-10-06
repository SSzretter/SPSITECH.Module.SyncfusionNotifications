del "*.nupkg"
"..\..\oqtane.framework\oqtane.package\nuget.exe" pack SPSITECH.Module.SyncfusionNotifications.nuspec 
XCOPY "*.nupkg" "..\..\oqtane.framework\Oqtane.Server\Packages\" /Y

