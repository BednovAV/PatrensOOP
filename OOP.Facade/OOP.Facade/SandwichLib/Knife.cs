namespace OOP.Facade.SandwichLib
{
    class Knife
    {
        public static PieceBread Cut(Bread bread)
        {
            return new PieceBread();
        }

        public static SausageField Cut(Sausage sausage)
        {
            return new SausageField();
        }
    }
}
