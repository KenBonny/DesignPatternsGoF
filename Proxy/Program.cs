using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // lazy loading is done with proxies.
            // the Lazy<T> is the proxy class that delays loading untill it's needed.
            // https://en.wikipedia.org/wiki/Proxy_pattern
            
            var car = new Car(new Pedal(new Engine()));
            var temperedCar = new Car(new TemperedPedalProxy(new Pedal(new Engine())));

            Console.WriteLine("How fast do you want to go?");
            var x = int.Parse(Console.ReadLine());
            
            car.Accelerate(x);
            Console.WriteLine();
            temperedCar.Accelerate(x);
            Console.ReadLine();
        }
    }
}
