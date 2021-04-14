using System;

namespace DesignPatterns.Bridge
{
    public class Hyundai : Make
    {
        public override void PerformRitual() => Console.WriteLine("Great Santa Fe");

        public override void StartEngine() => Console.WriteLine("Hold the start/stop button once");
    }
}