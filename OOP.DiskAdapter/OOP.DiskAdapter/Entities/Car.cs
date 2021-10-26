using OOP.DiskAdapter.Interfaces;
using System;

namespace OOP.DiskAdapter.Entities
{
    class Car
    {
        private Wheel_4x100 wheels;

        public void ScrewTheWheel(Wheel_4x100 wheels)
        {
            this.wheels = wheels;
            Console.WriteLine("Колеса установлены");
        }

        public void ShowWheels()
        {
            if (wheels != null)
            {
                wheels.ShowWheel_4x100();
            }
            else
            {
                Console.WriteLine("Колеса отсутствуют");
            }
        }
    }
}
