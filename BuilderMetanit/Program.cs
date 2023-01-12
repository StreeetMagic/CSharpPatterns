using System;

namespace Builder
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Baker baker = new Baker();
            
            BreadBuilder builder = new RyeBreadBuilder();
            
            Bread ryeBread = baker.Bake(builder);
            Console.WriteLine(ryeBread.ToString());
            
            builder = new WheatBreadBuilder();
            Bread wheatBread = baker.Bake(builder);
            Console.WriteLine(wheatBread.ToString());
            Console.Read();
        }
    }
}