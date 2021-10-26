using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace OOP.Serialization
{
    public static class Serialazer
    {
        public static void BinSer<T>(string file, T item)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            using (FileStream f = new FileStream(file + ".dat", FileMode.OpenOrCreate))
            {
                serializer.Serialize(f, item);
                Console.WriteLine($"{file + ".dat"} сериализован");
            }
        }

        public static void BinDes<T>(string file, out T item)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            using (FileStream f = File.OpenRead(file + ".dat"))
            {
                item = (T)serializer.Deserialize(f);
                Console.WriteLine($"{file + ".dat"} десериализован");
            }
        }

        public static void XmlSer<T>(string file, T item)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream f = new FileStream(file + ".xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(f, item);
                Console.WriteLine($"{file + ".xml"} сериализован");
            }
        }

        public static void XmlDes<T>(string file, out T item)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream f = File.OpenRead(file + ".xml"))
            {
                item = (T)serializer.Deserialize(f);
                Console.WriteLine($"{file + ".xml"} десериализован");
            }
        }

        public static void JsonSer<T>(string file, T item)
        {
            string itemJson = JsonConvert.SerializeObject(item);
            using (StreamWriter f = new StreamWriter(file + ".json"))
            {
                f.Write(itemJson);
                Console.WriteLine($"{file + ".json"} сериализован");
            }
        }

        public static void JsonDes<T>(string file, out T item)
        {
            string itemJson = File.ReadAllText(file + ".json");
            item = JsonConvert.DeserializeObject<T>(itemJson);
            Console.WriteLine($"{file + ".json"} десериализован");
        }

    }
}
