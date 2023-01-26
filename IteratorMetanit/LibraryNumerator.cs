namespace IteratorMetanit
{
    internal class LibraryNumerator : IBookIterator
    {
        readonly IBookNumerable _aggregate;
        private int _index;

        public LibraryNumerator(IBookNumerable a)
        {
            _aggregate = a;
        }

        public bool HasNext()
        {
            return _index < _aggregate.Count;
        }

        public Book Next()
        {
            return _aggregate[_index++];
        }
    }
}