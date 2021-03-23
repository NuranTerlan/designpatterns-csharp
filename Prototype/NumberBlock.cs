namespace DesignPatterns.Prototype
{
    public class NumberBlock : IBlock
    {
        public int Number { get; set; }

        public string Render => Number.ToString();

        public IBlock Clone() => new NumberBlock {Number = Number};

        public override string ToString()
        {
            return $"Right-aligned number - {Render}";
        }
    }
}