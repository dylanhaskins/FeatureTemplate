######################## SETUP 
. (Join-Path $PSScriptRoot "_Config.ps1")

if (!$Credentials)
{
	$Credentials = Get-Credential -Message "Credentials : $global:SolutionName @ $global:ServerUrl"
}
if (!$username)
{
	$username =  $Credentials.GetNetworkCredential().UserName
	$password =  $Credentials.GetNetworkCredential().Password
}

if (!$conn) {$conn = Connect-CrmOnline -Credential $Credentials -ServerUrl $global:ServerUrl}

if($conn.IsReady){

$message = "Generating Context and Types from $global:ServerUrl"
Write-Host $message
$ProgressBar = New-BTProgressBar -Status $message -Value 0.4
New-BurntToastNotification -Text $Text -ProgressBar $ProgressBar -Silent -UniqueIdentifier $UniqueId

Write-Host("Cleaning up Context Files...")
#clean up
Remove-Item (Join-Path $PSScriptRoot "..\Entities\Context") -Force -Recurse -ErrorAction Ignore
Remove-Item (Join-Path $PSScriptRoot "..\WebResources\typings\XRM") -Force -Recurse -ErrorAction Ignore

New-Item -ItemType Directory -Path (Join-Path $PSScriptRoot "..\Entities\Context") -ErrorAction Ignore
New-Item -ItemType Directory -Path (Join-Path $PSScriptRoot  "..\WebResources\typings\XRM") -ErrorAction Ignore

	#generate types
$CurrentLocation = Get-Location
Set-Location -Path (Join-Path $PSScriptRoot "..\XrmContext")
. .\XrmContext.exe /url:$global:ServerUrl/XRMServices/2011/Organization.svc /username:$username /password:$password /useconfig /out:"../Entities/Context"
Set-Location -Path (Join-Path $PSScriptRoot "..\XrmDefinitelyTyped")
. .\XrmDefinitelyTyped.exe /url:$global:ServerUrl/XRMServices/2011/Organization.svc /username:$username /password:$password /useconfig /out:"../Webresources/typings/XRM" /jsLib:"../Webresources/src/library"
Set-Location -Path $CurrentLocation
##Add Files to Project
[xml]$xdoc = (Get-Content (Join-Path $PSScriptRoot "..\AddName.csproj"))

[System.Xml.XmlNamespaceManager] $nsmgr = $xdoc.NameTable
$nsmgr.AddNamespace('a','http://schemas.microsoft.com/developer/msbuild/2003')

$nodes = $xdoc.SelectNodes("//a:Compile[contains(@Include,'Entities\Context')]",$nsmgr)
for ($i=0; $i -le ($nodes.Count-1); $i++)
        {
            $nodes[$i].ParentNode.RemoveChild($nodes[$i])
        }

$newnodes = $xdoc.SelectNodes("//a:Compile",$nsmgr)
$addNode = $newnodes[0].Clone()

Get-ChildItem (Join-Path $PSScriptRoot "..\Entities\Context") -Name | ForEach-Object {
	$newnodes = $xdoc.SelectNodes("//a:Compile",$nsmgr)
    $addNode = $newnodes[0].Clone()
	$addNode.Include = "Entities\Context\$_"; $newnodes[0].ParentNode.AppendChild($addNode)
}

$nodes = $xdoc.SelectNodes("//a:TypeScriptCompile[contains(@Include,'WebResources\typings\XRM')]",$nsmgr)
for ($i=0; $i -le ($nodes.Count-1); $i++)
        {
            $nodes[$i].ParentNode.RemoveChild($nodes[$i])
        }

Get-ChildItem (Join-Path $PSScriptRoot "..\WebResources\typings\XRM") -Name -Recurse | ForEach-Object {
	$newnodes = $xdoc.SelectNodes("//a:TypeScriptCompile",$nsmgr)
    $addNode = $newnodes[0].Clone()
	$addNode.Include = "WebResources\typings\XRM\$_"; $newnodes[0].ParentNode.AppendChild($addNode)
}

$xdoc.Save((Join-Path $PSScriptRoot "..\AddName.csproj"))
}