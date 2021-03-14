using System;

namespace DesignPatterns.Decorator
{
    public class OrderDecorator : OrderBase
    {
        protected OrderBase Order;

        public OrderDecorator(OrderBase order)
        {
            Order = order;
        }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price in a decorator class");
            return Order.CalculateTotalOrderPrice();
        }
    }
}