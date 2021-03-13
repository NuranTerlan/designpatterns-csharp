using System;
using System.Collections.Generic;
using DesignPatterns.Composite.Components;

namespace DesignPatterns.Composite.Composites
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private readonly IList<GiftBase> _gifts;
        private readonly bool _isRoot;

        public CompositeGift(string name, bool isRoot, int price = 0) : base(name, price)
        {
            this._isRoot = isRoot;
            _gifts = new List<GiftBase>();
        }

        public override int CalculateTotalPrice()
        {
            int total = 0;

            Console.WriteLine(_isRoot
                ? $"Root Gift => {this.name} contains the following products with prices: "
                : $"Inner Gift {this.name} contains the following products with prices: ");

            foreach (var gift in _gifts)
            {
                total += gift.CalculateTotalPrice();
            }

            if (_isRoot)
            {
                Console.WriteLine($"Total: {total}");
                Console.WriteLine("--------------");
            }

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