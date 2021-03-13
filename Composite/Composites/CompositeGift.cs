using System;
using System.Collections.Generic;
using DesignPatterns.Composite.Components;

namespace DesignPatterns.Composite.Composites
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private readonly IList<GiftBase> _gifts;

        public CompositeGift(string name, int price = 0) : base(name, price)
        {
            _gifts = new List<GiftBase>();
        }

        public override int CalculateTotalPrice()
        {
            int total = 0;

            Console.WriteLine($"{this.name} contains the following products with prices: ");

            foreach (var gift in _gifts)
            {
                total += gift.CalculateTotalPrice();
            }

            Console.WriteLine("--------------");

            return total;
        }

        public void Add(GiftBase gift)
        {
            _gifts.Add(gift);
        }

        public void Remove(GiftBase gift)
        {
            _gifts.Remove(gift);
        }
    }
}