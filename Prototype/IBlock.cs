namespace DesignPatterns.Prototype
{
    public interface IBlock
    {
        string Render { get; }

        IBlock Clone();
    }
}