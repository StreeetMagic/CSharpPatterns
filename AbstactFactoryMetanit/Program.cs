using System;
using AbstactFactoryMetanit.Heroes;
using AbstactFactoryMetanit.HeroFactories;

namespace AbstactFactoryMetanit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();
 
            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();
 
            Console.ReadLine();
        }
    }
}