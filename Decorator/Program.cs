using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // stream example, you can put a StreamWriter in an EncryptedStream and write an encrypted text to somewhere.
            // https://en.wikipedia.org/wiki/Decorator_pattern
            var player = new Player("Ken", Console.Out);
            player.Play();

            var quester = new QuestingPlayer(player);
            var fighter = new FightingPlayer(quester);
            fighter.Play();

            Console.WriteLine("{0} stopped questing.", player.Name);
            fighter = new FightingPlayer(player);
            fighter.Play();

            Console.WriteLine(player.ToString());
            Console.ReadLine();
        }
    }
}
