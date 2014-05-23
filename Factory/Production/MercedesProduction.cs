namespace Factory.Production
{
    public class MercedesProduction : IProduction
    {
        public string Engine { get; private set; }
        public string Door { get; private set; }
        public string Tires { get; private set; }
        public string Model { get; private set; }

        public MercedesProduction()
        {
            Engine = "Mercedes Engine";
            Door = "Mercedes Door";
            Tires = "Mercedes Tires";
            Model = "SLK";
        }
    }
}