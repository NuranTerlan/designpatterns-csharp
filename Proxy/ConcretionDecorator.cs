namespace DesignPatterns.Proxy
{
    public class ConcretionDecorator : IAbstraction
    {
        private readonly IAbstraction _abstraction;

        // concretion is known
        // runtime decision
        public ConcretionDecorator(IAbstraction abstraction)
        {
            _abstraction = abstraction;
        }

        // override concretion functionality
    }
}