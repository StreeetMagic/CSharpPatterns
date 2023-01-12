namespace DecoratorPattern
{
    abstract class Pizza
    {
        public Pizza(string n)
        {
            Name = n;
        }
        public string Name {get; protected set;}
        public abstract int GetCost();
    }
}