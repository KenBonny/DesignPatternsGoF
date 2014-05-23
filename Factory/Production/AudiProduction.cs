namespace Factory.Production
{
    public class AudiProduction : IProduction
    {
        public string Engine { get; private set; }
        public string Door { get; private set; }
        public string Tires { get; private set; }
        public string Model { get; private set; }

        public AudiProduction()
        {
            Engine = "Audi Engine";
            Door = "Audi Door";
            Tires = "Audi Tires";
            Model = "A6";
        }
    }
}