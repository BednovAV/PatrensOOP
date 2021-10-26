using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Singleton
{
    class CashAccount
    {
        private int money;

        private static CashAccount account;
        public static CashAccount GetInstance
        {
            get
            {
                if (account == null)
                {
                    account = new CashAccount();
                }
                return account;
            }
        }

        private CashAccount()
        {
            money = 0;
        }

        public void AddMoney(int x)
        {
            Console.WriteLine($"[Банк]: На счет зачислено {x} рублей");
            money += x;
        }

        public int MoneyOrder(int x)
        {
            if ((money - x) >= 0)
            {
                Console.WriteLine($"[Банк]: Списание {x} рублей");
                money -= x;
                return x;
            }
            else
            {
                Console.WriteLine("[Банк]: Недостаточно средств");
                return 0;
            }
        }

        public void CheckMoney()
        {
            Console.WriteLine($"[Банк]: На вашем счете {money} рублей");
        }
    }
}
