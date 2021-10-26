using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Singleton
{
    class Store
    {
        public static void Visit()
        {
            CashAccount acc = CashAccount.GetInstance;

            Console.WriteLine("[Магазин]: 1) Молоко - 50 рублей\n" +
                "[Магазин]: 2) Хлеб - 20 рублей\n" +
                "[Магазин]: 0) Выйти");

            string choice;
            do
            {
                Console.Write("[Магазин]: Ваш выбор: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (acc.MoneyOrder(50) == 50)
                        {
                            Console.WriteLine("[Магазин]: Вы купили молоко");
                        }
                        else
                        {
                            Console.WriteLine("[Магазин]: Что-то пошло не так");
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                        if (acc.MoneyOrder(20) == 20)
                        {
                            Console.WriteLine("[Магазин]: Вы купили хлеб");
                        }
                        else
                        {
                            Console.WriteLine("[Магазин]: Что-то пошло не так");
                        }
                        Console.WriteLine();
                        break;

                    default:
                        break;
                }

            } while (choice != "0");


        }


    }
}
