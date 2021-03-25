using System;

namespace DesignPatterns.Proxy
{
    public class ConcretionProxy : IAbstraction
    {
        // hide concretion, if we inject it we already exposed it
        // compile time decision
        Concretion concretion = new Concretion();

        // simulate/hook/intercept/interupt communication with Concretion
    }
}