using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Shoot();
            
            GameHistory game = new GameHistory();
            game.History.Push(hero.SaveState());
            
            hero.Shoot();
            
            hero.RestoreState(game.History.Pop());
            
            hero.Shoot();
            Console.Read();
        }
    }
}