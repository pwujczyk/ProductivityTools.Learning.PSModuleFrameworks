<!--Category:C#,Powershell--> 
 <p align="right">
    <a href="http://productivitytools.tech/productivitytools-createsqlserverdatabase/"><img src="Images/Header/ProductivityTools_green_40px_2.png" /><a> 
    <a href="https://www.github.com/pwujczyk/ProductivityTools.CreateSQLServerDatabase"><img src="Images/Header/Github_border_40px.png" /></a>
</p>
<p align="center">
    <a href="https://www.powershellgallery.com/packages/ProductivityTools.PSSetLockScreen/">
        <img src="Images/Header/LogoTitle_green_500px.png" />
    </a>
</p>


# PowerShell Module Frameworks

Writing PowerShell binary modules now requires to understood couple concepts:
- Difference between PowerShell and PowerShell Core
- .NET Framework and .NET Core frameworks
- .NET Standard API
<!--more-->

Slide below summarize what I learnt and code helps to understood.

<!--og-image-->
![Create database](Images/PowerShellAndPowerShellCore-BinaryModules.png)

If you would like to test code, build application and open the TestModules.ps1 script in **PowerShell** and **PowerShell Core**. You will see that most of the modules works correctly, only module executed in **PowerShell Core** which contains code which **PowerShell Core** doesn't support (WCF) - fails.