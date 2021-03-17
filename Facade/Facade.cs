using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Facade
{
    public class Facade
    {
        private readonly OnlineRestaurant _restaurant;
        private readonly ShippingService _shippingService;

        public Facade(OnlineRestaurant restaurant, ShippingService shippingService)
        {
            _restaurant = restaurant;
            _shippingService = shippingService;
        }

        public void OrderFood(IList<Order> orders)
        {
            foreach (var order in orders)
            {
                _restaurant.AddOrderToCart(order);
            }
            _restaurant.CompleteOrders();
            foreach (var order in orders)
            {
                _shippingService.AcceptOrder(order);
                _shippingService.ShipOrder();
            }

            Console.WriteLine($"The total amount of orders: ${orders.Sum(o => o.FullPrice)}");
        }
    }
}