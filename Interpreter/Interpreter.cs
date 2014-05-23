namespace Interpreter
{
    public class Interpreter
    {
        public double Evaluate()
        {
            // normally this is the parser/lexer's job
            // http://pragprog.com/book/tpdsl/language-implementation-patterns
            IExpression expression = new Times(new Plus(new Number(8), new Number(5)), new Minus(new Number(10), new Number(6)));
            return expression.Interpret();
        }
    }

    public interface IExpression
    {
        double Interpret();
    }

    abstract class BinaryOperator : IExpression
    {
        protected readonly IExpression Left;
        protected readonly IExpression Right;

        public BinaryOperator(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public abstract double Interpret();
    }

    class Plus : BinaryOperator
    {
        public Plus(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Interpret()
        {
            return Left.Interpret() + Right.Interpret();
        }
    }

    class Minus : BinaryOperator
    {
        public Minus(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Interpret()
        {
            return Left.Interpret() - Right.Interpret();
        }
    }

    class Times : BinaryOperator
    {
        public Times(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Interpret()
        {
            return Left.Interpret()*Right.Interpret();
        }
    }

    class Number : IExpression
    {
        private readonly double _value;

        public Number(double value)
        {
            _value = value;
        }

        public double Interpret()
        {
            return _value;
        }
    }
}