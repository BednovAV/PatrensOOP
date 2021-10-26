using OOP.DiskAdapter.Entities;

namespace OOP.DiskAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // покупаем машину
            Car myCar = new Car();

            // покупаем понравившиеся колесные диски
            Disk myDisk = new Disk();

            // пытаемся установить их
            //myCar.ScrewTheWheel(myDisk);
            // не получается, так как они не подходят
            myCar.ShowWheels();

            // покупаем переходник и прикручиваем к нему наше колесо
            WheelsAdapter_5x98to4x100 wheelsAdapter = new WheelsAdapter_5x98to4x100(myDisk);

            // теперь устанавливаем колеса с переходником
            myCar.ScrewTheWheel(wheelsAdapter);

            // проверяем
            myCar.ShowWheels();
        }
    }
}
