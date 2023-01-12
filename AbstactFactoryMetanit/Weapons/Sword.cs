using System;

namespace AbstactFactoryMetanit.Weapons
{
    internal class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}