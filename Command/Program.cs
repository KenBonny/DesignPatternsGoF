using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a queue of commands and executes it when you deem appropriate
            // example: ICommand, undo/redo functionality. for each action, an inverse action
            // is a pushed onto a stack and popped when the appropriate button is clicked
            // CQRS uses the command pattern
            // https://en.wikipedia.org/wiki/Command_pattern

            var command = new Command();
            //command.CanExecuteChanged += (sender, eventArgs) => Console.WriteLine("Action added.");
            command.Add(() => Console.WriteLine("I'm creating an action."));
            command.Add(() => Console.WriteLine("But it's not getting executed just yet."));
            command.Add(() => Console.WriteLine("For that I need to process the queue."));
            command.Add(() => Console.WriteLine("Voila, done!"));

            Console.WriteLine("Executing commands sequentially:");
            command.Execute(true);
            Console.WriteLine();
            Console.WriteLine("Executing commands in parallell:");
            command.Execute(false);
            Console.ReadLine();
        }
    }
}
