using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.GasolineDomain
{
    public interface IGasolineDomain
    {
        public string Start();

        public string Stop();

        public string Refuel();
    }
}
