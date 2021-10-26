using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            BreakfastFacade breakfast = new BreakfastFacade();

            breakfast.Show();

            breakfast.MakeBreakfast();

            breakfast.Show();
        }
    }
}
