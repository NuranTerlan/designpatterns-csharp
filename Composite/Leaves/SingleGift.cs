using System;
using DesignPatterns.Composite.Components;

namespace DesignPatterns.Composite.Leaves
{
    public class SingleGift : GiftBase
    {
        public SingleGift(string name, int price) : base(name, price)
        {
        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{this.name} -> ${price}");

            return price;
        }
    }
}