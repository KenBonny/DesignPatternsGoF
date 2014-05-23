using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            // an object will have a state object. The state object will contain
            // the actual implementation of the objects code. that way, you can change
            // the state in the object and change the objects implementation.
            // the state can ask for a reference to the object so
            // it can use the objects properties and fields.
            // example: in gaming: character reacts differently on seeing someone
            // based on whether the character is in combat or not 
            // (object: character, state: combat/non-combat)
            // https://en.wikipedia.org/wiki/State_pattern

            var person = new Person("Ken");
            person.Speak();
            person.Annoy();
            person.Speak();
            Console.ReadLine();
        }


    }
}
