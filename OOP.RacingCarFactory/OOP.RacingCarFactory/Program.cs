using OOP.RacingCarFactory.Ferrari;
using OOP.RacingCarFactory.Interfacecs;
using OOP.RacingCarFactory.MercedessAMG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.RacingCarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какий болид вам требудется\n" +
                "\t1. Mercedes-AMG\n" +
                "\t2. Scuderia Ferrari");

            IRacingFactory racingCarFactory = null;

            string select;
            do
            {
                Console.Write("Ваш выбор: ");
                select = Console.ReadLine();

                if (select == "1")
                {
                    racingCarFactory = new MercedesAMG();
                }
                else if (select == "2")
                {
                    racingCarFactory = new ScuderiaFerrari();
                }
                else
                {
                    Console.WriteLine("Что-то не то...");
                }
            } while ((select != "1") && (select != "2"));

            IChassis chassis = racingCarFactory.CreateChassis();
            IEngine engine = racingCarFactory.CreateEngine();


            Console.WriteLine("Доступные компоненты:");
            chassis.Show();
            engine.Show();
        }
    }
}
