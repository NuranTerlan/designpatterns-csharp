namespace DesignPatterns.FacetedB
{
    public class CarAddressBuilder : CarBuilderFacade
    {
        public CarAddressBuilder(Car car)
        {
            Car = car;
        }

        public CarAddressBuilder InCity(string city)
        {
            Car.InCity = city;
            return this;
        }

        public CarAddressBuilder InDealer(string dealer)
        {
            Car.InDealer = dealer;
            return this;
        }
    }
}