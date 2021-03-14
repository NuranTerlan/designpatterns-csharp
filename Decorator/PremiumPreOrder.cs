using System;

namespace DesignPatterns.Decorator
{
    public class PremiumPreOrder : OrderDecorator
    {
        public PremiumPreOrder(OrderBase order) : base(order)
        {
        }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in the {nameof(PremiumPreOrder)} class");
            var preOrderPrice = base.CalculateTotalOrderPrice();

            Console.WriteLine("Adding additional discount to a pre-order price for premium users");
            return preOrderPrice * 0.9;
        }
    }
}