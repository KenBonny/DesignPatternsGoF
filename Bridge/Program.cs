using System;
using System.Collections.Generic;
using Bridge.Animals;
using Bridge.Format;
using Bridge.Tools;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // When a class varies often, the features of object-oriented programming become very useful
            // because changes to a program's code can be made easily with minimal prior knowledge about the program.
            // The bridge pattern is useful when both the class as well as what it does vary often.
            // https://en.wikipedia.org/wiki/Bridge_pattern
            var dog = new Dog();
            var cat = new Cat();
            var horse = new Horse();

            dog.Sound.Writer = Console.Out;
            cat.Sound.Writer = Console.Out;
            horse.Sound.Writer = Console.Out;

            dog.MakeSound();
            cat.MakeSound();
            horse.MakeSound();

            Console.WriteLine();
            Console.WriteLine("------");
            Console.WriteLine();

            var tools = new List<Tool>
            {
                new Line(new JPG()),
                new Ellipse(new SVG()),
                new Rectangle(new PNG())
            };

            foreach (var tool in tools)
            {
                tool.Save(Console.Out);
            }

            Console.ReadLine();
        }
    }
}
