using System;

namespace ConsoleApplication1
{
    class Hero
    {
        private int patrons=10; // кол-во патронов
        private int lives=5; // кол-во жизней
 
        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine("Производим выстрел. Осталось {0} патронов", patrons);
            }
            else
                Console.WriteLine("Патронов больше нет");
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine("Сохранение игры. Параметры: {0} патронов, {1} жизней", patrons, lives);
            return new HeroMemento(patrons, lives);
        }
 
        public void RestoreState(HeroMemento memento)
        {
            patrons=memento.Patrons;
            lives = memento.Lives;
            Console.WriteLine("Восстановление игры. Параметры: {0} патронов, {1} жизней", patrons, lives);
        }
    }
}