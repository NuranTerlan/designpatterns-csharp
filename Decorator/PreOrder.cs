using System;
using System.Linq;

namespace DesignPatterns.Decorator
{
    public class PreOrder : OrderBase
    {
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a pre-order");
            // 10% discount applied
            return this.Products.Sum(p => p.Price) * 0.9;
        }
    }
}