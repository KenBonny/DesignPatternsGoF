namespace Factory.Production
{
    public class VolkswagenProduction : IProduction
    {
        public string Engine { get; private set; }
        public string Door { get; private set; }
        public string Tires { get; private set; }
        public string Model { get; private set; }

        public VolkswagenProduction()
        {
            Engine = "Volkswagen Engine";
            Door = "Volkswagen Door";
            Tires = "Volkswagen Tires";
            Model = "GTI";
        }
    }
}