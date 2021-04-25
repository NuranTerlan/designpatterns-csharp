namespace DesignPatterns.Iterator
{
    public class CustomLinkedList<T>
    {
        private CustomNode<T> Head { get; set; }

        public CustomLinkedList() {}

        public CustomLinkedList(T head)
        {
            Head = new CustomNode<T>(head);
        }

        public void Add(T value)
        {
            if (Head == null)
            {
                Head = new CustomNode<T>(value);
                return;
            }

            Head.Append(value);
        }

        public T Get(int i) => Head.Get(i);

        public CustomLinkedIterator<T> Iterator => new CustomLinkedIterator<T>(Head);
    }
}