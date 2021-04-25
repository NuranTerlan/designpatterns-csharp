namespace DesignPatterns.Iterator
{
    public class CustomLinkedIterator<T>
    {
        private readonly CustomNode<T> _root;
        private CustomNode<T> _current;

        public CustomLinkedIterator(CustomNode<T> root)
        {
            _root = _current = root;
        }

        public T Next()
        {
            var value = _current.Value;
            _current = _current.Next;
            return value;
        }

        public bool Complete => _current == null;

        public void Reset()
        {
            _current = _root;
        }
    }
}