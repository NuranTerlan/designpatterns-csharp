using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPatterns.Singleton
{
    public class SingletonDataContainer : ISingletonContainer
    {
        private readonly Dictionary<string, int> _capitals;

        private SingletonDataContainer()
        {
            Console.WriteLine("Initializing singleton object");
            _capitals = new Dictionary<string, int>();

            var elements = File.ReadAllLines("capitals.txt");
            for (int i = 0; i < elements.Length; i += 2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i + 1]));
            }
        }

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }

        private static readonly Lazy<SingletonDataContainer> Instance;

        static SingletonDataContainer()
        {
            Instance = new Lazy<SingletonDataContainer>();
        }

        public static SingletonDataContainer GetInstance => Instance.Value;
    }
}