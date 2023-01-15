using System;

namespace StateMetanit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();
 
            Console.Read();
        }
    }
}