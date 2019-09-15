
Set-Location $PSScriptRoot
dotnet clean


$directories = @("bin", "obj")
 
foreach ($directory in $directories)
{
    Get-ChildItem -Directory -Recurse | ? { $_.Name -eq $directory } | Remove-Item -Recurse -Confirm:$false -Verbose
}

Read-Host -Prompt "Press Enter to exit"