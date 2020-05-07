# ProductivityTools.Learning.PSModuleFrameworks

Writing PowerShell binary modules now requires to understood couple concepts:
- Difference between Powershell and Powershell Core
- .NET Framework and .NET Core frameworks
- .NET Standard API

Slide below summarize what I learnt and code helps to understood.

![Create database](Images/PowerShellAndPowerShellCore-BinaryModules.png)

If you would like to test code, build application and open the TestModules.ps1 script in **Powershell** and **Powershell Core**. You will see that most of the modules works correctly, only module executed in **Powershell Core** which contains code which **Powershell Core** doesn't support (WCF) - fails.