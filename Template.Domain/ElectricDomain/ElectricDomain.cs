using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.ElectricDomain
{
    public class ElectricDomain
    {
        public void Start() 
        {
            Console.WriteLine("Electric Star");
        }

        public void Stop()
        {
            Console.WriteLine("Electric Stop");
        }

        public void Connect()
        {
            Console.WriteLine("Electric Connet");
        }

        public void Disconnect()
        {
            Console.WriteLine("Electric Disconnect");
        }
    }
}
