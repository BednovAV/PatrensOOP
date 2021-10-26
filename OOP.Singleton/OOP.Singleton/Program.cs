using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // идем на работу
            Work.EarnMoney();

            Console.WriteLine();

            // проверяем счет
            CashAccount acc = CashAccount.GetInstance;
            acc.CheckMoney();

            Console.WriteLine();

            // идем в магазин
            Store.Visit();
        }
    }
}
