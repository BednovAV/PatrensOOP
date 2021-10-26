using OOP.RacingCarFactory.Interfacecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.RacingCarFactory.MercedessAMG
{
    class MercedesChassis : IChassis
    {
        public void Show()
        {
            Console.WriteLine("Шасси Mercedes-AMG");
        }
    }
}
