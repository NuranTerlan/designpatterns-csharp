using System;
using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod
{
    public class AirConditioner
    {
        private readonly Dictionary<Actions, AirConditionerFactory> _factories;

        private AirConditioner()
        {
            // MANUAL IMPLEMENTATION
            //_factories = new Dictionary<Actions, AirConditionerFactory>
            //{
            //    {Actions.Cooling, new CoolingFactory()},
            //    {Actions.Warming, new WarmingFactory()}
            //};

            // IMPLEMENTATION WITH REFLECTION
            _factories = new Dictionary<Actions, AirConditionerFactory>();
            foreach (Actions action in Enum.GetValues(typeof(Actions)))
            {
                var factory = (AirConditionerFactory) Activator
                    .CreateInstance(Type.GetType("DesignPatterns.FactoryMethod." +
                                                 Enum.GetName(typeof(Actions), action) +
                                                 "Factory"));
                _factories.Add(action, factory);
            }
        }

        // factory method refactoring technique
        public static AirConditioner InitializeFactories() => new AirConditioner();

        public IAirConditioner ExecuteCreation(Actions action, double temperature) =>
            _factories[action].Create(temperature);
    }
}