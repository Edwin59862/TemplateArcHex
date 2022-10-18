using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.DieselDomain
{
    public interface IDieselDomain
    {
        public string Start();

        public string Stop();

        public string Refuel();
    }
}
