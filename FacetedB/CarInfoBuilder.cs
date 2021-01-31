namespace DesignPatterns.FacetedB
{
    public class CarInfoBuilder : CarBuilderFacade
    {
        public CarInfoBuilder(Car car)
        {
            Car = car;
        }

        public CarInfoBuilder WithBrand(CarBrands brand)
        {
            Car.Brand = brand;
            return this;
        }

        public CarInfoBuilder WithModel(string model)
        {
            Car.Model = model;
            return this;
        }

        public CarInfoBuilder CreatedAt(int year)
        {
            Car.CreationYear = year;
            return this;
        }

        public CarInfoBuilder WithDistance(double distance)
        {
            Car.DistanceWithKm = distance;
            return this;
        }
    }
}