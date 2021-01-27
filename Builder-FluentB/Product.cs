using System;

namespace DesignPatterns
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int NumberInStock { get; set; }
    }
}