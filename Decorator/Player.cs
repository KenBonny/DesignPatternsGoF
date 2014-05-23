using System.IO;

namespace Decorator
{
    public interface IPlayer
    {
        void Play();
    }

    public class Player : IPlayer
    {
        public string Name { get; private set; }

        public int Level { get; internal set; }

        public readonly TextWriter Writer;

        public Player(Player player)
        {
            Writer = player.Writer;
            Name = player.Name;
            Level = player.Level;
        }

        public Player(string name, TextWriter writer)
        {
            Name = name;
            Writer = writer;
            Level = 0;

            Writer.WriteLine("{0} is born.", Name);
        }

        public virtual void Play()
        {
            Writer.WriteLine("{0} is playing.", Name);
        }

        public override string ToString()
        {
            return string.Format("{0} is level {1}.", Name, Level);
        }
    }

    public class QuestingPlayer : Player
    {
        private readonly Player _player;

        public QuestingPlayer(Player player) : base(player)
        {
            _player = player;
        }

        public override void Play()
        {
            _player.Play();
            _player.Level++;
            Writer.WriteLine("{0} grew stronger. Level: {1}", Name, Level);
        }
    }

    public class SellingPlayer : Player
    {
        private readonly Player _player;

        public SellingPlayer(Player player) : base(player)
        {
            _player = player;
        }
        
        public override void Play()
        {
            Writer.WriteLine("{0} is earning heaps of cash.", _player.Name);
            _player.Play();
        }
    }

    public class FightingPlayer : Player
    {
        private readonly Player _player;

        public FightingPlayer(Player player) : base(player)
        {
            _player = player;
        }

        public override void Play()
        {
            Writer.WriteLine("{0} charges an enemy! Wow, much violence, so aggressive.", _player.Name);
            _player.Play();
        }
    }
}