namespace DesignPatterns.Iterator
{
    public class CustomNode<T>
    {
        public T Value { get; set; }
        public CustomNode<T> Next { get; set; }

        public CustomNode(T value)
        {
            Value = value;
            Next = null;
        }

        public void Append(T value)
        {
            if (Next == null)
            {
                Next = new CustomNode<T>(value);
                return;
            }

            Next.Append(value);
        }

        public T Get(int i) => i == 0 ? Value : Next.Get(--i);
    }
}