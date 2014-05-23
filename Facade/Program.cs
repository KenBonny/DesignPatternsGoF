using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // just like the facade of a building, this hides what is in the dll
            // and exposes an easy to use way to interact with the library.
            // https://en.wikipedia.org/wiki/Facade_pattern
            Console.WriteLine(new Facade().Run());
            Console.ReadLine();
        }
    }
}
