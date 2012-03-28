<#


#>

param(
    [string]$SiteName = "ConfigTool",
    [string]$ConfigToolDir = (Split-Path -parent $MyInvocation.MyCommand.Definition) + '\Deployment\',
    [int]$Port = 8585
    
)

## Add ConfigTool Website to local IIS
## Requires IIS Administration Access, Import Now.
Import-Module WebAdministration -ErrorAction SilentlyContinue

## Commands

$SetAppPool = { param($Name) Set-ItemProperty IIS:\Sites\$Name -Name applicationPool -Value $Name}

## Step 1: Create Application Pool
New-Item IIS:\AppPools\$SiteName -Force; 
Set-ItemProperty IIS:\AppPools\$SiteName managedRuntimeVersion v4.0 -Force

## Step 2: Create Website

New-Item IIS:\Sites\$Name -bindings $Binding -PhysicalPath $PhysicalPath


## Step 3: Configure Website




## Step 4: Make Money
## This step is completely up to you to fulfill