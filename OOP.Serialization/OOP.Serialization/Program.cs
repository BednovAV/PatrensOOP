using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Serialization
{
    [Serializable]
    public class SchoolBag
    {
        public bool Maths { get; set; }
        public bool Physics { get; set; }
        public bool Chemistry { get; set; }
        public bool History { get; set; }
        public bool Informatics { get; set; }
        public bool Literature { get; set; }
        public bool PencilCase { get; set; }
        public bool Lunch { get; set; }
        public bool IndoorShoes { get; set; }

        public SchoolBag()
        {
            this.Maths = false;
            this.Physics = false;
            this.Chemistry = false;
            this.History = false;
            this.Informatics = false;
            this.Literature = false;
            this.PencilCase = false;
            this.Lunch = false;
            this.IndoorShoes = false;
        }

        public void ShowBag()
        {
            Console.WriteLine("Содержимое рюкзака:");

            int k = 1;

            if (Maths)
            {
                Console.WriteLine($"{k}. Учебник по математике");
                k++;
            }

            if (Physics)
            {
                Console.WriteLine($"{k}. Учебник по физике");
                k++;
            }

            if (Chemistry)
            {
                Console.WriteLine($"{k}. Учебник по химии");
                k++;
            }

            if (History)
            {
                Console.WriteLine($"{k}. Учебник по истории");
                k++;
            }

            if (Informatics)
            {
                Console.WriteLine($"{k}. Учебник по информатике");
                k++;
            }

            if (Literature)
            {
                Console.WriteLine($"{k}. Учебник по литературе");
                k++;
            }

            if (PencilCase)
            {
                Console.WriteLine($"{k}. Пенал");
                k++;
            }

            if (Lunch)
            {
                Console.WriteLine($"{k}. Еда для перекуса");
                k++;
            }

            if (IndoorShoes)
            {
                Console.WriteLine($"{k}. Сменная обувь");
                k++;
            }
        }
    }

    interface Builder
    {
        void Reset();
        void PutMath();
        void PutPhysics();
        void PutChemistry();
        void PutHistory();
        void PutInformatics();
        void PutLiterature();
        void PutPencilCase();
        void PutLunch();
        void PutIndoorShoes();
    }

    class BagBuilder : Builder
    {
        private SchoolBag bag;

        public BagBuilder()
        {
            bag = new SchoolBag();
        }
        public SchoolBag GetBag()
        {
            return bag;
        }

        public void PutChemistry()
        {
            bag.Chemistry = true;
        }

        public void PutHistory()
        {
            bag.History = true;
        }

        public void PutIndoorShoes()
        {
            bag.IndoorShoes = true;
        }

        public void PutInformatics()
        {
            bag.Informatics = true;
        }

        public void PutLiterature()
        {
            bag.Literature = true;
        }

        public void PutLunch()
        {
            bag.Lunch = true;
        }

        public void PutMath()
        {
            bag.Maths = true;
        }

        public void PutPencilCase()
        {
            bag.PencilCase = true;
        }

        public void PutPhysics()
        {
            bag.Physics = true;
        }

        public void Reset()
        {
            bag = new SchoolBag();
        }
    }

   

    class Director
    {
        public static void PackForMonday(Builder builder)
        {
            builder.Reset();

            builder.PutPencilCase();
            builder.PutLunch();
            builder.PutIndoorShoes();
            builder.PutHistory();
            builder.PutPhysics();
            builder.PutLiterature();
        }

        public static void PackForTuesday(Builder builder)
        {
            builder.Reset();

            builder.PutPencilCase();
            builder.PutLunch();
            builder.PutIndoorShoes();
            builder.PutMath();
            builder.PutChemistry();
            builder.PutLiterature();
        }

        public static void PackForWednesday(Builder builder)
        {
            builder.Reset();

            builder.PutPencilCase();
            builder.PutLunch();
            builder.PutIndoorShoes();
            builder.PutInformatics();
            builder.PutLiterature();
            builder.PutMath();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<SchoolBag> schoolBags = new List<SchoolBag>();

            // создаем builder рюкзака
            BagBuilder bagBuilder = new BagBuilder();

            for (int i = 0; i < 10; i++)
            {
                // просим директора собрать рюкзак для понедельника
                Director.PackForMonday(bagBuilder);
                // забираем результат у строителя рюкзака
                schoolBags.Add(bagBuilder.GetBag());
            }

            Serialazer.BinSer("bag", schoolBags);
            Serialazer.BinDes("bag", out schoolBags);

            Serialazer.XmlSer("bag", schoolBags);
            Serialazer.XmlDes("bag", out schoolBags);

            Serialazer.JsonSer("bag", schoolBags);
            Serialazer.JsonDes("bag", out schoolBags);

            //// Бинарная сериализация
            //Serialazer.BinSer("bag", schoolBag);
            //SchoolBag schoolBagBin;
            //Serialazer.BinDes("bag", out schoolBagBin);
            //Console.WriteLine("ПОСЛЕ ДВОИЧНОЙ СЕРИАЛИЗАЦИИ");
            //schoolBagBin.ShowBag();
            //Console.WriteLine();

            //// XML сериализация
            //Serialazer.XmlSer("bag", schoolBag);
            //SchoolBag schoolBagXml;
            //Serialazer.XmlDes("bag", out schoolBagXml);
            //Console.WriteLine("ПОСЛЕ XML СЕРИАЛИЗАЦИИ");
            //schoolBagXml.ShowBag();
            //Console.WriteLine();

            //// JSON сериализация
            //Serialazer.JsonSer("bag", schoolBag);
            //SchoolBag schoolBagJson;
            //Serialazer.XmlDes("bag", out schoolBagJson);
            //Console.WriteLine("ПОСЛЕ JSON СЕРИАЛИЗАЦИИ");
            //schoolBagJson.ShowBag();
            //Console.WriteLine();
        }
    }
}
