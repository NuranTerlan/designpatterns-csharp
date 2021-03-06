﻿using System;
using DesignPatterns.Command.Receivers;

namespace DesignPatterns.Command
{
    public class ProductCommand : ICommand
    {
        private readonly Product2 _product;
        private readonly PriceAction _priceAction;
        private readonly int _amount;

        public bool IsCommandExecuted { get; private set; }

        public ProductCommand(Product2 product, PriceAction priceAction, int amount)
        {
            _product = product;
            _priceAction = priceAction;
            _amount = amount;
        }


        public void ExecuteAction()
        {
            if (_priceAction == PriceAction.Increase)
            {
                _product.IncreasePrice(_amount);
                IsCommandExecuted = true;
                return;
            }

            IsCommandExecuted = _product.DecreasePrice(_amount);
        }

        public void UndoAction()
        {
            if (!IsCommandExecuted) return;

            Console.Write("Undo => ");

            if (_priceAction == PriceAction.Increase)
            {
                _product.DecreasePrice(_amount);
                return;
            }

            _product.IncreasePrice(_amount);
        }
    }
}