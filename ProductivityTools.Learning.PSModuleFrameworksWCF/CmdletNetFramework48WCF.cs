using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Learning.PSModuleFrameworks.NetFramework48WCF
{
    [Cmdlet(VerbsDiagnostic.Test, "NetFramework48WCF")]
    public class CmdletNetFramework48WCF : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(Service1));
            WriteObject("Hello from NetFramework48WCF");
        }
    }

    public class Service1 { }
}
