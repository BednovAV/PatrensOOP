using OOP.RacingCarFactory.Interfacecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.RacingCarFactory.Ferrari
{
    class FerrariEngine : IEngine
    {
        public void Show()
        {
            Console.WriteLine("Двигатель Scuderia Ferrari");
        }
    }
}
