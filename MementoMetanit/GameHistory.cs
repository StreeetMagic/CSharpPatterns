using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }
        
        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }
}