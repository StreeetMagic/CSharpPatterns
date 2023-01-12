using System;

namespace AbstactFactoryMetanit.Movements
{
    internal class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}