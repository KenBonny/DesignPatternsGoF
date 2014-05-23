using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // adapts an old or incompatible method into an excpected result.
            // https://en.wikipedia.org/wiki/Adapter_pattern
            IPerson person = new PersonAdapter(new OldPerson());
            Console.WriteLine("This person is {0} years old.", person.GetAge());
            Console.ReadLine();
        }
    }

    internal class PersonAdapter : IPerson
    {
        private readonly IHasBirthday _old;

        public PersonAdapter(IHasBirthday old)
        {
            _old = old;
        }

        public int GetAge()
        {
            var span = DateTime.Now - _old.GetBirthday();
            return span.Days/365;
        }
    }

    internal class OldPerson : IHasBirthday
    {
        public DateTime GetBirthday()
        {
            return new DateTime(1987, 4, 13);
        }
    }

    internal interface IHasBirthday
    {
        DateTime GetBirthday();
    }

    internal interface IPerson
    {
        int GetAge();
    }
}
