using System;
using FactoryMethodMetanit.Developers;
using FactoryMethodMetanit.Houses;

namespace FactoryMethodMetanit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            House house2 = dev.Create();
         
            dev = new WoodDeveloper("Частный застройщик");
            House house = dev.Create();
 
            Console.ReadLine();
        }
    }

}