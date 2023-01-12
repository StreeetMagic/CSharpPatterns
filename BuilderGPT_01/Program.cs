using System;

namespace BuilderGPT_01
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var pizzaBuilder = new PizzaBuilder();
            var pizza = pizzaBuilder
                .AddDough("Thin")
                .AddSauce("Tomato")
                .AddTopping("Mozzarella")
                .Build();

            Console.WriteLine("Pizza with "
                              + pizza.Dough + " dough, "
                              + pizza.Sauce + " sauce, and "
                              + pizza.Topping + " topping.");
            
            Console.ReadKey();
        }
    }

    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }
    }

    public class PizzaBuilder
    {
        private Pizza _pizza;

        public PizzaBuilder()
        {
            _pizza = new Pizza();
        }

        public PizzaBuilder AddDough(string dough)
        {
            _pizza.Dough = dough;

            return this;
        }

        public PizzaBuilder AddSauce(string sauce)
        {
            _pizza.Sauce = sauce;

            return this;
        }

        public PizzaBuilder AddTopping(string topping)
        {
            _pizza.Topping = topping;

            return this;
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
}