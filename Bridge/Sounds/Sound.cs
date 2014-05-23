using System.IO;

namespace Bridge.Sounds
{
    public abstract class Sound
    {
        public TextWriter Writer { get; set; }

        public virtual void MakeSound()
        {
            Writer.WriteLine("Make a sound.");
        }
    }

    public class DogSound : Sound
    {
        public override void MakeSound()
        {
            Writer.WriteLine("A dog barks.");
        }
    }

    public class CatSound : Sound
    {
        public override void MakeSound()
        {
            Writer.WriteLine("A cat meows.");
        }
    }

    public class HorseSound : Sound
    {
        public override void MakeSound()
        {
            Writer.WriteLine("A horse neighs.");
        }
    }
}