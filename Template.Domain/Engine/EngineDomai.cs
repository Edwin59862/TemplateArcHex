using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.ActionDomain
{
    public abstract class EngineDomai
    {
        public abstract string Start();
        public abstract string Stop();
        public abstract string Refuel();
    }
}
