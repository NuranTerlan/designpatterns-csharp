namespace DesignPatterns.Prototype
{
    public class TextBlock : IBlock
    {
        public string Content { get; set; }

        public string Render => Content;

        public IBlock Clone() => new TextBlock {Content = Content};

        public override string ToString()
        {
            return $"Left-aligned text - {Render}";
        }
    }
}