using System;

namespace OOP.Facade.CoffeeLib
{
    class Coffee
    {
        private CoffeeBeans coffeeBeans;
        private BoiledWater boiledWater;

        public Coffee(CoffeeBeans coffeeBeans, BoiledWater boiledWater)
        {
            this.coffeeBeans = coffeeBeans;
            this.boiledWater = boiledWater;
        }

        public void Show()
        {
            Console.WriteLine("Чашка кофе");
        }
    }
}
