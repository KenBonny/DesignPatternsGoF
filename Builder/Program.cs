using System;
using System.Drawing;
using System.Threading;
using Builder.Enumerations;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            // https://en.wikipedia.org/wiki/Builder_pattern
            var dashboard = GetEnum<Dashboard>();
            var engine = GetEnum<Engine>();
            var fuel = GetEnum<Fuel>();
            var wheels = GetEnum<Wheels>();
            var color = Color.Red;
            Console.WriteLine("Do you want ESP? y/n");
            var esp = Console.ReadLine().StartsWith("y",true, Thread.CurrentThread.CurrentCulture);

            var builder = new CarBuilder();
            builder.SetColor(color);
            builder.SetDashboard(dashboard);
            builder.SetEngine(engine);
            builder.SetEsp(esp);
            builder.SetFuel(fuel);
            builder.SetWheels(wheels);
            var car = builder.BuilCar();

            Console.WriteLine(car);
            Console.ReadLine();
        }

        private static T GetEnum<T>()
        {
            var type = typeof (T);
            Console.WriteLine("What type of {0} would you like?", type.Name);
            var i = 1;
            foreach (var name in Enum.GetNames(type))
            {
                Console.WriteLine("{0}. {1}", i, name);
                i++;
            }
            var id = int.TryParse(Console.ReadLine(), out i);
            var items = Enum.GetValues(type) as T[];
            return items[i - 1];
        }
    }
}
