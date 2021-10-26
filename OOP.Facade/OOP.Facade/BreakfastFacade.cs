using OOP.Facade.CoffeeLib;
using OOP.Facade.SandwichLib;
using System;
using System.Diagnostics;

namespace OOP.Facade
{
    class BreakfastFacade
    {
        private Coffee coffee;
        private Sandwich sandwich;

        public BreakfastFacade()
        {
            coffee = null;
            sandwich = null;
        }

        public void MakeBreakfast()
        {
            // делаем кофе
            BoiledWater boiledWater = new BoiledWater(); // набираем воду
            CoffeeBeans coffeeBeans = new CoffeeBeans(); // берем зерна
            coffee = new Coffee(coffeeBeans, boiledWater); // варим кофе

            // делаем бутерброд
            Bread bread = new Bread(); // покупаем хлеб
            Sausage sausage = new Sausage(); // покупаем колбасу
            PieceBread pieceBread = Knife.Cut(bread); // режем хлеб
            SausageField sausageField = Knife.Cut(sausage); // режем колбасу
            sandwich = new Sandwich(pieceBread, sausageField); // складываем все вместе

            Console.WriteLine("Завтрак готов");
        }

        public void Show()
        {
            if(coffee == null || sandwich == null)
            {
                Console.WriteLine("Завтрак еще не готов");
            }
            else
            {
                Console.WriteLine("Завтрак:");
                Console.Write("\t");
                coffee.Show();
                Console.Write("\t");
                sandwich.Show();
            }
        }

    }
}
