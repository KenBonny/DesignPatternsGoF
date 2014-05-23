using System.Drawing;
using Builder.Enumerations;

namespace Builder
{
    public class CarBuilder
    {
        private readonly Car _car = new Car();

        public void SetWheels(Wheels wheels)
        {
            _car.Wheels = wheels;
        }

        public void SetColor(Color color)
        {
            _car.Color = color;
        }

        public void SetDashboard(Dashboard dashboard)
        {
            _car.Dashboard = dashboard;
        }

        public void SetEngine(Engine engine)
        {
            _car.Engine = engine;
        }

        public void SetFuel(Fuel fuel)
        {
            _car.Fuel = fuel;
        }

        public void SetEsp(bool esp)
        {
            _car.ESP = esp;
        }

        public Car BuilCar()
        {
            return _car;
        }
    }
}