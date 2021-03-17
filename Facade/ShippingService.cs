using System;

namespace DesignPatterns.Facade
{
    public class ShippingService
    {
        private Order _order;

        public void AcceptOrder(Order order)
        {
            _order = order;
            CalculateShippingExpenses();
        }

        private void CalculateShippingExpenses() => _order.ShippingPrice = 15.5;

        public void ShipOrder()
        {
            Console.WriteLine(_order);
            Console.WriteLine($"Order is being shipped to {_order.ShippingAddress}");
        }
    }
}