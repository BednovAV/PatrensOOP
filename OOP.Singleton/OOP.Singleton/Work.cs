using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Singleton
{
    class Work
    {
        public static void EarnMoney()
        {
            CashAccount acc = CashAccount.GetInstance;
            acc.AddMoney(100);
            Console.WriteLine("[Работа]: Вы заработали 100 рублей");
        }
    }
}
