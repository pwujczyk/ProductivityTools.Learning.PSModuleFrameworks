Import-Module .\ProductivityTools.Learning.PSModuleFrameworks.NetFramework48.dll
Import-Module .\netcoreapp3.1\ProductivityTools.Learning.PSModuleFrameworks.NetCore31.dll
Import-Module .\netstandard2.0\ProductivityTools.Learning.PSModuleFrameworks.NetStandard20.dll

Test-NetCore31
Test-NetFramework48
Test-NetStandard20