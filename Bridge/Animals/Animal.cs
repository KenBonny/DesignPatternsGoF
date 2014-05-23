using Bridge.Sounds;

namespace Bridge.Animals
{
    public class Animal
    {
        public string Name { get; set; }

        public Sound Sound { get; set; }

        public Sound Type { get; set; }

        public Animal(Sound sound)
        {
            Sound = sound;
        }

        public void MakeSound()
        {
            Sound.MakeSound();
        }
    }

    public class Dog : Animal {
        public Dog() : base(new DogSound())
        {
        }
    }

    public class Cat : Animal {
        public Cat() : base(new CatSound())
        {
        }
    }

    public class Horse : Animal {
        public Horse() : base(new HorseSound())
        {
        }
    }
}