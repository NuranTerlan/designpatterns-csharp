namespace DesignPatterns.FacetedB
{
    public class CarTradeBuilder : CarBuilderFacade
    {
        public CarTradeBuilder(Car car)
        {
            Car = car;
        }

        public CarTradeBuilder WithPrice(decimal price)
        {
            Car.Price = price;
            return this;
        }

        public CarTradeBuilder IsSecondHand(bool isSecondHand)
        {
            Car.IsSecondHand = isSecondHand;
            return this;
        }
    }
}