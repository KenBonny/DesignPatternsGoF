using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // adds functionality to a class
            // example: extention method
            // https://en.wikipedia.org/wiki/Visitor_pattern

            var vehicle = new Vehicle();
            vehicle.Horn();

            vehicle = new Car();
            vehicle.Horn();

            var car = new Car();
            car.Horn();

            var truck = new Truck();
            truck.Horn();

            Console.ReadLine();
        }
    }
}
