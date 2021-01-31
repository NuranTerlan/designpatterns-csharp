namespace DesignPatterns.FacetedB
{
    public class CarBuilderFacade
    {
        public Car Car { get; set; }

        public CarBuilderFacade()
        {
            Car = new Car();
        }

        public Car Build() => Car;

        public CarInfoBuilder Info => new CarInfoBuilder(Car);
        public CarEngineBuilder Engine => new CarEngineBuilder(Car);
        public CarTradeBuilder Trade => new CarTradeBuilder(Car);
        public CarAddressBuilder Address => new CarAddressBuilder(Car);
    }
}