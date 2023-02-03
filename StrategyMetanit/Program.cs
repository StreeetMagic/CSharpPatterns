using System;

namespace StategyMetanit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Car auto = new Car(4, "Volvo", new PetrolMove());
            
            auto.Move();
            
            auto.Movable = new ElectricMove();
            auto.Move();
 
            Console.ReadLine();
        }
    }
}