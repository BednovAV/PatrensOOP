using OOP.RacingCarFactory.Interfacecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.RacingCarFactory.MercedessAMG
{
    class MercedesAMG : IRacingFactory
    {
        public IChassis CreateChassis()
        {
            return new MercedesChassis();
        }

        public IEngine CreateEngine()
        {
            return new MercedesEngine();
        }
    }
}
