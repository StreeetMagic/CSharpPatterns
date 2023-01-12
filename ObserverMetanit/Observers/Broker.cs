using System;

namespace ObserverMetanit
{
    internal class Broker : IObserver
    {
        private readonly string _name;
        IObservable _stock;

        public Broker(string name, IObservable obs)
        {
            _name = name;
            _stock = obs;
            _stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            Console.WriteLine(
                sInfo.Usd > 30
                    ? "Брокер {0} продает доллары;  Курс доллара: {1}"
                    : "Брокер {0} покупает доллары;  Курс доллара: {1}", _name, sInfo.Usd);
        }

        public void StopTrade()
        {
            _stock.RemoveObserver(this);
            _stock = null;
        }
    }
}