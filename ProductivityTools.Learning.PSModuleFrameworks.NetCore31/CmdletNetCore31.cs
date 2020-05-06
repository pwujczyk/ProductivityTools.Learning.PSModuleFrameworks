using System;
using System.Management.Automation;

namespace ProductivityTools.Learning.PSModuleFrameworks.NetCore31
{
    [Cmdlet(VerbsDiagnostic.Test, "NetCore31")]
    public class CmdletNetCore31 : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject("Hello from NetCore31");
        }
    }
}
