using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Decorator
{
    class Program
    {
        interface ICocktail
        {
            string GetTaste();
        }

        class MilkShake : ICocktail
        {
            public string GetTaste()
            {
                return "Вкус молочного коктейля";
            }
        }

        abstract class CoctailDecorator : ICocktail
        {
            private ICocktail cocktail;

            public CoctailDecorator(ICocktail cocktail)
            {
                this.cocktail = cocktail;
            }

            public virtual string GetTaste()
            {
                return cocktail.GetTaste();
            }
        }

        class StrawberryMilkshake : CoctailDecorator
        {
            public StrawberryMilkshake(ICocktail cocktail) : base(cocktail) { }

            public override string GetTaste()
            {
                return base.GetTaste() + "\n\tс клубникой";
            }
        }

        class BananaMilkshake : CoctailDecorator
        {
            public BananaMilkshake(ICocktail cocktail) : base(cocktail) { }

            public override string GetTaste()
            {
                return base.GetTaste() + "\n\tс бананом";
            }
        }

        class OrangeMilkshake : CoctailDecorator
        {
            public OrangeMilkshake(ICocktail cocktail) : base(cocktail) { }

            public override string GetTaste()
            {
                return base.GetTaste() + "\n\tс апельсином";
            }
        }
        static void Main(string[] args)
        {
            ICocktail cocktail1 = new MilkShake();

            cocktail1 = new StrawberryMilkshake(cocktail1);
            Console.WriteLine(cocktail1.GetTaste());

            cocktail1 = new OrangeMilkshake(cocktail1);
            Console.WriteLine(cocktail1.GetTaste());

            cocktail1 = new BananaMilkshake(cocktail1);
            Console.WriteLine(cocktail1.GetTaste());


            ICocktail cocktail2 = new MilkShake();

            cocktail2 = new OrangeMilkshake(cocktail2);
            Console.WriteLine(cocktail2.GetTaste());

            cocktail2 = new BananaMilkshake(cocktail2);
            Console.WriteLine(cocktail2.GetTaste());

            cocktail2 = new StrawberryMilkshake(cocktail2);
            Console.WriteLine(cocktail2.GetTaste());

        }
    }
}
