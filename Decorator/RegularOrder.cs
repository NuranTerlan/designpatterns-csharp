using System;
using System.Linq;

namespace DesignPatterns.Decorator
{
    public class RegularOrder : OrderBase
    {
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a regular order");
            return this.Products.Sum(p => p.Price);
        }
    }
}