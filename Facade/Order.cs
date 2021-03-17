namespace DesignPatterns.Facade
{
    public class Order
    {
        public string DishName { get; set; }
        public double DishPrice { get; set; }
        public string User { get; set; }
        public string ShippingAddress { get; set; }
        public double ShippingPrice { get; set; }

        public double FullPrice => DishPrice + ShippingPrice;

        public override string ToString()
        {
            return $"{DishName} has been ordered by {User}\nThe full price is ${FullPrice}";
        }
    }
}