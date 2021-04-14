using System;

namespace DesignPatterns.Bridge
{
    public class Nissan : Make
    {
        public override void PerformRitual() => Console.WriteLine("Hit the car");

        public override void StartEngine() => Console.WriteLine("Fix the wiring\n" +
                                                                "Put the key" +
                                                                "Turn the key");
    }
}