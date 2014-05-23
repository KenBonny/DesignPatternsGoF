using System;

namespace State
{
    internal class Person
    {
        public string Name { get; private set; }
        private IState _state = new HappyState();

        public Person(string name)
        {
            Name = name;
        }

        public void Speak()
        {
            _state.Speak(this);
        }

        public void Annoy()
        {
            _state = new AngryState();
        }
    }

    internal class AngryState : IState
    {
        public void Speak(Person person)
        {
            Console.WriteLine("{0} SMASH!", person.Name.ToUpper());
        }
    }

    internal class HappyState : IState
    {
        public void Speak(Person person)
        {
            Console.WriteLine("{0} is very happy!", person.Name);
        }
    }

    internal interface IState
    {
        void Speak(Person person);
    }
}