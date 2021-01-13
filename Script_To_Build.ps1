    param
    (
        [parameter(Mandatory=$true)]
        [String] $path,

        [parameter(Mandatory=$true)]
        [ValidateScript( {
            if (-Not ($_ | Test-Path -PathType Leaf) ) {
                throw "The Path argument must be a file. Folder paths are not allowed."
            }
            return $true
        })]        
        [String] $msBuildExe
    )

    Clear-Host;

    Write-Host "Building $($path)" -foregroundcolor green
    & "$($msBuildExe)" "$($path)"  /t:Clean /t:Build /m
