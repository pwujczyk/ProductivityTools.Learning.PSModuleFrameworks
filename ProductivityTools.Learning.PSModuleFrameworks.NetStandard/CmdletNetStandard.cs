using System;
using System.Management.Automation;

namespace ProductivityTools.Learning.PSModuleFrameworks.NetStandard20
{
   [Cmdlet(VerbsDiagnostic.Test, "NetStandard20")]
    public class CmdletCmdletNetStandard20 : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject("Hello from NetStandard20");
        }
    }
}
