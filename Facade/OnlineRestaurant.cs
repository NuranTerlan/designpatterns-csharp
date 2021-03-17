using System;
using System.Collections.Generic;

namespace DesignPatterns.Facade
{
    public class OnlineRestaurant
    {
        private readonly IList<Order> _cart;

        public OnlineRestaurant()
        {
            _cart = new List<Order>();
        }

        public OnlineRestaurant(IList<Order> cart)
        {
            _cart = cart;
        }

        public void AddOrderToCart(Order order)
        {
            _cart.Add(order);
        }

        public void RemoveOrderFromCart(Order order)
        {
            _cart.Remove(order);
        }

        public void CompleteOrders()
        {
            Console.WriteLine("Orders completed. Dispatch in progress...");
        }
    }
}