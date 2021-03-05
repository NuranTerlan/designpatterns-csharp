﻿namespace DesignPatterns.FactoryMethod
{
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create(double temperature);
    }
}