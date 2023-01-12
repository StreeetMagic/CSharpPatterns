namespace DecoratorPattern
{
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza Pizza;
        
        public PizzaDecorator(string n, Pizza pizza) : base(n)
        {
            Pizza = pizza;
        }
    }
}