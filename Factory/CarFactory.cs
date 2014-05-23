namespace Factory
{
    public static class CarFactory
    {
        public static Car CreateCar(ManufacturerEnum manufacturer)
        {
            var production = ProductionFactory.CreateProduction(manufacturer);
            return new Car
            {
                Door = production.Door,
                Engine = production.Engine,
                Manufacturer = manufacturer.ToString(),
                Model = production.Model,
                Tires = production.Tires
            };
        }
    }
}