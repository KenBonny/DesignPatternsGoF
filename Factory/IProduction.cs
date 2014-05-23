namespace Factory
{
    public interface IProduction
    {
        string Engine { get; }

        string Door { get; }

        string Tires { get; }

        string Model { get; }
    }
}