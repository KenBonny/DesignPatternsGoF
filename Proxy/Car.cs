using System;

namespace Proxy
{
    public class Car
    {
        private IPedal _pedal;

        public Car(IPedal pedal)
        {
            _pedal = pedal;
        }

        public void Accelerate(int x)
        {
            _pedal.Press(x);
        } 
    }

    public interface IPedal
    {
        void Press(int x);
    }

    public class Pedal : IPedal
    {
        private Engine _engine;

        public Pedal(Engine engine)
        {
            _engine = engine;
        }

        public void Press(int x)
        {
            Console.WriteLine("Pedal to the metal!");
            var y = (double) x/100;
            _engine.InjectFuel(y);
        }
    }

    public class Engine
    {
        public void InjectFuel(double y)
        {
            Console.WriteLine("Injecting {0} litres of fuel.", y);
        }
    }

    public class TemperedPedalProxy : IPedal
    {
        private IPedal _pedal;

        public TemperedPedalProxy(IPedal pedal)
        {
            _pedal = pedal;
        }

        public void Press(int x)
        {
            if (x > 100)
                x = 100;
            if (x < 0)
                x = 0;

            Console.WriteLine("This is a tempered pedal. No speeding.");
            _pedal.Press(x);
        }
    }
}