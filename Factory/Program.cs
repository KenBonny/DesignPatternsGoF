using System;
using System.Linq;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://en.wikipedia.org/wiki/Factory_pattern
            while (true)
            {
                Console.WriteLine("What car would you like to make?");
                var i = 1;
                foreach (var name in Enum.GetNames(typeof(ManufacturerEnum)).OrderBy(x => x))
                {
                    Console.WriteLine("{0}. {1}", i, name);
                    i++;
                }
                var id = Console.ReadLine();
                ManufacturerEnum manufacturer;

                switch (id)
                {
                    case "1":
                        manufacturer = ManufacturerEnum.Audi;
                        break;
                    case "2":
                        manufacturer = ManufacturerEnum.BMW;
                        break;
                    case "3":
                        manufacturer = ManufacturerEnum.Mercedes;
                        break;
                    case "4": 
                        manufacturer = ManufacturerEnum.Volkswagen;
                        break;
                    default:
                        return;
                }

                var car = CarFactory.CreateCar(manufacturer);
                Console.WriteLine();
                Console.WriteLine("{0} {1}: {2} - {3} - {4}", car.Manufacturer, car.Model, car.Door, car.Tires, car.Engine);
                Console.WriteLine();
            }
        }
    }
}
