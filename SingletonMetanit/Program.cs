using System;

namespace SingletonMetanit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Launch("Windows 8.1");
            Console.WriteLine(computer.OperatingSystem.Name);

            computer.OperatingSystem = OperatingSystem.GetInstance("Windows 10");
            Console.WriteLine(computer.OperatingSystem.Name);

            Console.ReadLine();
        }
    }
}

// https://metanit.com/sharp/patterns/2.3.php