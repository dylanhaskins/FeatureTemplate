﻿@echo off
set package_root=..\..\..\PackageDeployer\
REM Find Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase.dll in the package folder (irrespective of version)
For /R %package_root% %%G IN (Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase.dll) do (
	IF EXIST "%%G" (set xrm_path=%%G
	goto :tooling)
	)

:tooling
For /R %package_root% %%G IN (Microsoft.Xrm.Tooling.Connector.dll) do (
	IF EXIST "%%G" (set tooling_path=%%G
	goto :continue)
	)

:continue
@echo Using '%xrm_path%' 
roslyn\csc.exe /target:library ..\..\Deployment\FeatureTemplatePackage.cs /r:"%xrm_path%" /r:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.1\System.ComponentModel.Composition.dll"

xcopy FeatureTemplatePackage.dll ..\..\..\PackageDeployer\bin\%1\. /y
xcopy Deployment\. ..\..\..\PackageDeployer\bin\%1\. /s/e/y

if errorlevel 1 (
echo Error Code=%errorlevel%
exit /b %errorlevel%
)