

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
Remove-Item ((Split-Path $MyInvocation.InvocationName) + "..\Entities\Context") -Force -Recurse -ErrorAction Ignore
Remove-Item ((Split-Path $MyInvocation.InvocationName) + "..\WebResources\typings\XRM") -Force -Recurse -ErrorAction Ignore

New-Item -ItemType Directory -Path ((Split-Path $MyInvocation.InvocationName) + "..\Entities\Context")
New-Item -ItemType Directory -Path ((Split-Path $MyInvocation.InvocationName) + "..\WebResources\typings\XRM")

	#generate types
& ((Split-Path $MyInvocation.InvocationName) + "..\XrmContext\XrmContext.exe") /url:$global:ServerUrl/XRMServices/2011/Organization.svc /username:$username /password:$password /useconfig /out:((Split-Path $MyInvocation.InvocationName) + "..\Entities\Context")
& ((Split-Path $MyInvocation.InvocationName) + "..\XrmDefinitelyTyped\XrmDefinitelyTyped.exe") /url:$global:ServerUrl/XRMServices/2011/Organization.svc /username:$username /password:$password /useconfig /out:((Split-Path $MyInvocation.InvocationName) + "..\WebResources\typings\XRM") /jsLib:((Split-Path $MyInvocation.InvocationName) + "..\WebResources\src\library")
}