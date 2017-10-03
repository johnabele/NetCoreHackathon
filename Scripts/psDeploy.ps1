Import-Module WebAdministration

# Modify these variable values.
$siteName="ContosoClaimService"
$sitePort="8085"
$projectDir="C:\Projects\ContosoClaimService\ContosoClaimService"
$msdeployArguments = '-verb:sync', 
    '-source:contentPath="C:\Projects\ContosoClaimService\ContosoClaimService\bin\Debug\netcoreapp1.1\publish"', 
    '-dest:contentPath="'+${siteName}+'"'

# Modify these variable only if necessary
$msdeploy = "C:\Program Files\IIS\Microsoft Web Deploy V3\msdeploy.exe"
$sitePath = Join-Path -Path "C:\inetpub\wwwroot" -ChildPath $siteName

# Check for physical path
if (-not (Test-Path -path $sitePath))
{
    New-Item -Path $sitePath -type directory 
}

# Check for site
$site = Get-WebSite | where { $_.Name -eq $siteName }
if($site -eq $null)
{
    # Make app pool
   $appPool = New-Item IIS:\AppPools\$siteName

    # Make website
    $iisApp = New-WebSite -Name $siteName -Port $sitePort -HostHeader "" -ApplicationPool $siteName -PhysicalPath "$Env:systemdrive\inetpub\wwwroot\$siteName"
    $iisApp | Set-ItemProperty -Name "applicationPool" -Value $siteName
}    
Set-ItemProperty "IIS:\AppPools\$siteName" managedRuntimeVersion "" -verbose

# dotnet core build & deploy commands
dotnet.exe build $projectDir
dotnet.exe publish $projectDir

# Run msdeploy 
& $msdeploy $msdeployArguments

Write-Host "`r`n"
Write-Host "Website: $siteName has been created. Navigate to http://localhost:$sitePort/" to view the site. -foregroundcolor "Yellow"