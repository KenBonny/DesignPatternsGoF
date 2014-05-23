namespace Facade
{
    public class Facade
    {
        public string Run()
        {
            var complexity = new Complexity();

            return string.Format("{0} {1}", complexity.PartA(), complexity.PartB());
        }
    }

    internal class Complexity
    {
        public string PartA()
        {
            return "The first part.";
        }

        public string PartB()
        {
            return "The last part.";
        }
    }
}