namespace Factory.Production
{
    public class BmwProduction : IProduction
    {
        public string Engine { get; private set; }
        public string Door { get; private set; }
        public string Tires { get; private set; }
        public string Model { get; private set; }

        public BmwProduction()
        {
            Engine = "BMW Engine";
            Door = "BMW Door";
            Tires = "BMW Tires";
            Model = "116";
        }
    }
}