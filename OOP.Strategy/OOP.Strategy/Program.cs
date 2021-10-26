using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Strategy
{
    class Program
    {
        interface IPlaySoundStrategy
        {
            void Play(string sound);
        }

        class HeadphonesStrategy : IPlaySoundStrategy
        {
            public void Play(string sound)
            {
                Console.WriteLine($"[Звук в наушниках]: {sound}");
            }
        }

        class LoudspeakersStrategy : IPlaySoundStrategy
        {
            public void Play(string sound)
            {
                Console.WriteLine($"[Звук в колонках]: {sound}");
            }
        }

        class Computer
        {
            public IPlaySoundStrategy PlaySoundStrategy { set; private get; }

            public Computer(IPlaySoundStrategy playSoundStrategy)
            {
                PlaySoundStrategy = playSoundStrategy;
                PlaySound("*звук включения компьютера*");
            }

            public void PlaySound(string sound)
            {
                Console.Write("[Компьютер]");
                PlaySoundStrategy.Play(sound);
            }
        }

        class Phone
        {
            public IPlaySoundStrategy PlaySoundStrategy { set; private get; }

            public Phone(IPlaySoundStrategy playSoundStrategy)
            {
                PlaySoundStrategy = playSoundStrategy;
            }

            public void PlaySound(string sound)
            {
                Console.Write("[Телефон]");
                PlaySoundStrategy.Play(sound);
            }
        }
        static void Main(string[] args)
        {
            IPlaySoundStrategy headphonesStrategy = new HeadphonesStrategy();
            IPlaySoundStrategy loudspeakersStrategy = new LoudspeakersStrategy();

            // включаем компьютер в режиме воспроизведения звука через колонки
            Computer computer = new Computer(loudspeakersStrategy);
            computer.PlaySound("Ла-ла-ла-ла-ла");

            // переключаемся на наушники
            computer.PlaySoundStrategy = headphonesStrategy;
            computer.PlaySound("Ла-ля-ля-ла-бум-ля-ля");

            Phone phone = new Phone(headphonesStrategy);
            phone.PlaySound("пш-пш-пш");

            phone.PlaySoundStrategy = loudspeakersStrategy;
            phone.PlaySound("фффффффффф");
        }
    }
}
