using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.ActionDomain;

namespace Template.Domain.ElectricDomain
{
    public class ElectricAdapter : EngineDomai, IElectricDomain
    {
        ElectricDomain electricDomain = new ElectricDomain();

        public override string Start()
        {
            electricDomain.Connect();
            electricDomain.Start();
            return "Start Electric";
        }

        public override string Stop()
        {
            electricDomain.Stop();
            electricDomain.Disconnect();
            return "Start Electric";
        }

        public override string Refuel()
        {
            electricDomain.Connect();
            return "Start Electric";
        }
    }
}
