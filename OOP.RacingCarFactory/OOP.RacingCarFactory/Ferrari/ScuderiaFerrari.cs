using OOP.RacingCarFactory.Interfacecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.RacingCarFactory.Ferrari
{
    class ScuderiaFerrari : IRacingFactory
    {
        public IChassis CreateChassis()
        {
            return new FerrariChassis();
        }

        public IEngine CreateEngine()
        {
            return new FerrariEngine();
        }
    }
}
