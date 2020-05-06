using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Learning.PSModuleFrameworks.NetStandard48WCF
{
    [Cmdlet(VerbsDiagnostic.Test, "NetFramework48WCF")]
    public class CmdletNetFramework48 : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject("Hello from NetFramework48");
        }
    }
}
