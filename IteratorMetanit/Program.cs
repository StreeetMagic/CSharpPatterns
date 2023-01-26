using System;

namespace IteratorMetanit
{
    internal static class Program
    {
        private static void Main()
        {
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.Read();
        }
    }
}