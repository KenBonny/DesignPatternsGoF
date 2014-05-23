using System;

namespace Visitor
{
    public static class Extension
    {
         public static void Horn(this Vehicle vehicle)
         {
             Console.WriteLine("Vehicle horn");
         }

        public static void Horn(this Car car)
        {
            Console.WriteLine("Car horn");
        }

        public static void Horn(this Truck truck)
        {
            Console.WriteLine("Truck horn");
        }
    }
}