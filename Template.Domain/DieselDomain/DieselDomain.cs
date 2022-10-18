using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.ActionDomain;

namespace Template.Domain.DieselDomain
{
    public class DieselDomain : EngineDomai, IDieselDomain
    {
        public override string Start()
        {
            return "Start Diesel";
        }

        public override string Stop()
        {
            return "Stop Diesel";
        }

        public override string Refuel()
        {
            return "Refuel Diesel";
        }
    }
}
