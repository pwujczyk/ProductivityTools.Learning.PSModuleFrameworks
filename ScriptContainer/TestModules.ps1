Import-Module .\ProductivityTools.Learning.PSModuleFrameworks.NetFramework48.dll
Import-Module .\ProductivityTools.Learning.PSModuleFrameworks.NetFramework48WCF.dll
Import-Module .\netcoreapp3.1\ProductivityTools.Learning.PSModuleFrameworks.NetCore31.dll
Import-Module .\netstandard2.0\ProductivityTools.Learning.PSModuleFrameworks.NetStandard20.dll

Test-NetCore31
Test-NetStandard20
Test-NetFramework48
Test-NetFramework48WCF