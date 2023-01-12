namespace ConsoleApplication1
{
    class HeroMemento
    {
        public int Patrons { get; private set; }
        public int Lives { get; private set; }
 
        public HeroMemento(int patrons, int lives)
        {
            Patrons = patrons;
            Lives = lives;
        }
    }
}