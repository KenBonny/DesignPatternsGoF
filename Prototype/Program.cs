using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // ken is the prototype, except a few things, the properties won't change much in clones.
            // https://en.wikipedia.org/wiki/Prototype_pattern
            var ken = new Prototype
            {
                Name = "Ken",
                Age = 27
            };

            var barry = (Prototype) ken.Clone();
            barry.Name = "Barry";
        }
    }

    class Prototype : ICloneable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        /// <summary>
        /// The prototye
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Prototype
            {
                Age = Age,
                Name = Name
            };
        }
    }
}
