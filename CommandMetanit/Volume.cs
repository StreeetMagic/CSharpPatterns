using System;

namespace CommandMetanit
{
    internal class Volume
    {
        private const int MinValue = 0;
        private const int MaxValue = 20;
        
        private int _level;

        public Volume()
        {
            _level = MinValue;
        }

        public void RaiseLevel()
        {
            if (_level < MaxValue)
                _level++;
            
            Console.WriteLine("Уровень звука {0}", _level);
        }

        public void DropLevel()
        {
            if (_level > MinValue)
                _level--;
            
            Console.WriteLine("Уровень звука {0}", _level);
        }
    }
}