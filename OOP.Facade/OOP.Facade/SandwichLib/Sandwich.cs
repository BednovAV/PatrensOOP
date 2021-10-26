using System;


namespace OOP.Facade.SandwichLib
{
    class Sandwich
    {
        private PieceBread bread;
        private SausageField sausage;

        public Sandwich(PieceBread bread, SausageField sausage)
        {
            this.bread = bread;
            this.sausage = sausage;
        }

        public void Show()
        {
            Console.WriteLine("Бутерброд");
        }
    }
}
