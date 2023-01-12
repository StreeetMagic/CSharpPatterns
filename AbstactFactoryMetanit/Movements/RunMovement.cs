using System;

namespace AbstactFactoryMetanit.Movements
{
    internal class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}