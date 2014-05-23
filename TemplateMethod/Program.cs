using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // the template method allows a part to be unknown at compile time
            // a function (or lambda) can be passed into the method to determine a part of the solution
            // example: Where(x => x.Age >= 18)
            // https://en.wikipedia.org/wiki/Template_pattern

            var people = GetPeople();
            foreach (var person in people.Where(p => p.Age >= 18))
            {
                Console.WriteLine(person.Name);
            }
            Console.ReadLine();
        }

        private static List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person{Age = 27, Name = "Ken"},
                new Person{Age = 22, Name = "Joeri"},
                new Person{Age = 17, Name = "Anton"}
            };
        } 
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
