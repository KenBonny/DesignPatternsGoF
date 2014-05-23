using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            // used a lot when building compilers.
            // it interprets the code you write and converts it into an expression tree.
            // looks like a composite pattern, mostly because it looks like a (binary) expression tree.
            // https://en.wikipedia.org/wiki/Interpreter_pattern
            // http://math.hws.edu/javanotes/c9/expressionTree.png

            var interpreter = new Interpreter();

            Console.WriteLine(interpreter.Evaluate());
            Console.ReadLine();
        }
    }
}
