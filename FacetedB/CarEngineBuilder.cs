namespace DesignPatterns.FacetedB
{
    public class CarEngineBuilder : CarBuilderFacade
    {
        public CarEngineBuilder(Car car)
        {
            Car = car;
        }

        public CarEngineBuilder WithEngine(double engine = 2000.0)
        {
            Car.Engine = engine;
            return this;
        }

        public CarEngineBuilder WithHorsePower(int horsePower)
        {
            Car.HorsePower = horsePower;
            return this;
        }

        public CarEngineBuilder WithTorque(int torque)
        {
            Car.Torque = torque;
            return this;
        }
    }
}