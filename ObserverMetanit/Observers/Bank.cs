using System;

namespace ObserverMetanit
{
    internal class Bank : IObserver
    {
        private readonly string _name;

        public Bank(string name, IObservable obs)
        {
            _name = name;
            obs.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            Console.WriteLine(
                sInfo.Euro > 40 
                    ? "Банк {0} продает евро;  Курс евро: {1}" 
                    : "Банк {0} покупает евро;  Курс евро: {1}", _name, sInfo.Euro);
        }
    }
}