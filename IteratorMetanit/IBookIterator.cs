namespace IteratorMetanit
{
    internal interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}