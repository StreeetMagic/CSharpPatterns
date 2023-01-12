using System;

namespace AbstactFactoryMetanit.Weapons
{
    internal class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }
}