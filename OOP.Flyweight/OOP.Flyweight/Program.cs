using System;
using System.Collections.Generic;

namespace OOP.Flyweight
{
    class Program
    {
        class Shoe
        {
            ShoeCategory category;
            string color;
            int size;

            public Shoe(ShoeCategory category, string color, int size)
            {
                this.category = category;
                this.color = color;
                this.size = size;
            }

            public string GetShoe()
            {
                return string.Format($"{category.CategoryName}:\n" +
                                     $"  Цвет: {color}\n" +
                                     $"  Размер: {size}");
            }
        }

        class ShoeCategory
        {
            public string CategoryName { get; }
            public ShoeCategory(string CategoryName)
            {
                this.CategoryName = CategoryName;
            }

            // Мелочи, связанные с пошивкой обуви
            //...
            //...   
        }

        class ShoeFactory
        {
            private static Dictionary<string, ShoeCategory> _categories = new Dictionary<string, ShoeCategory>();

            public ShoeFactory()
            {
                _categories.Add("Ботинки", new ShoeCategory("Ботинки"));
                _categories.Add("Кроссовки", new ShoeCategory("Кроссовки"));
                _categories.Add("Кеды", new ShoeCategory("Кеды"));
            }

            public ShoeCategory GetCategory (string name)
            {
                if (_categories.ContainsKey(name))
                {
                    return _categories[name];
                }
                else
                {
                    _categories.Add(name, new ShoeCategory(name));
                    return _categories[name];
                }
            }
        }


        static void Main(string[] args)
        {
            ShoeFactory shoeFactory = new ShoeFactory();

            // выбираем размер
            int size = 44;

            // делаем список обуви, которую нужно купить
            string[] categories =
            {
                "Ботинки",
                "Кеды",
                "Кроссовки",
                "Тапочки"
            };

            // делаем список допустимых для нас цветов
            string[] colors =
            {
                "красный",
                "черный",
                "синий",
                "фиолетовый"
            };

            Random rnd = new Random();

            // чемодан для покупок
            List<Shoe> shoes = new List<Shoe>();

            // идем покупать обувь
            foreach(var category in categories)
            {
                ShoeCategory shoeCategory = shoeFactory.GetCategory(category);
                shoes.Add(new Shoe(shoeCategory, colors[rnd.Next(0, colors.Length)], size));
            }

            // смотрим покупки
            foreach (var shoe in shoes)
            {
                Console.WriteLine(shoe.GetShoe());
            }
        }
    }
}
