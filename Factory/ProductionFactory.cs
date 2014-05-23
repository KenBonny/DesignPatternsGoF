using Factory.Production;

namespace Factory
{
    public static class ProductionFactory
    {
        public static IProduction CreateProduction(ManufacturerEnum manufacturer)
        {
            switch (manufacturer)
            {
                case ManufacturerEnum.Audi:
                    return new AudiProduction();
                case ManufacturerEnum.BMW:
                    return new BmwProduction();
                case ManufacturerEnum.Mercedes:
                    return new MercedesProduction();
                default:
                    return new VolkswagenProduction();
            }
        }
    }
}