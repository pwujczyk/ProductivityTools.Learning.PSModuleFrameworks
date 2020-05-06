using System;
using System.Management.Automation;

namespace ProductivityTools.Learning.PSModuleFrameworks.NetStandard20
{
   [Cmdlet(VerbsDiagnostic.Test, "NetFramework48")]
    public class CmdletCmdletNetStandard20 : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject("Hello from NetFramework48");
        }
    }
}
