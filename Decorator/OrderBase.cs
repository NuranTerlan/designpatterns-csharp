using System.Collections.Generic;

namespace DesignPatterns.Decorator
{
    public abstract class OrderBase
    {
        protected IList<Product> Products = new List<Product>
        {
            new Product {Name = "Phone", Price = 587},
            new Product {Name = "Tablet", Price = 800},
            new Product {Name = "PC", Price = 1200}
        };

        public abstract double CalculateTotalOrderPrice();
    }
}