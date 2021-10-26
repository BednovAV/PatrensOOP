using OOP.DiskAdapter.Interfaces;

namespace OOP.DiskAdapter
{
    class WheelsAdapter_5x98to4x100 : Wheel_4x100
    {
        private Wheel_5x98 wheel;

        public WheelsAdapter_5x98to4x100(Wheel_5x98 wheel)
        {
            this.wheel = wheel;
        }

        public void ShowWheel_4x100()
        {
            wheel.ShowWheel_5x98();
        }
    }
}
