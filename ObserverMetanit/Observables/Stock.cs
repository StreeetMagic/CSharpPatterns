using System;
using System.Collections.Generic;

namespace ObserverMetanit
{
    internal class Stock : IObservable
    {
        private readonly StockInfo _stockInfo;
        private readonly List<IObserver> _observers;

        public Stock()
        {
            _observers = new List<IObserver>();
            _stockInfo = new StockInfo();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in _observers)
            {
                o.Update(_stockInfo);
            }
        }

        public void Market()
        {
            Random rnd = new Random();
            _stockInfo.Usd = rnd.Next(20, 40);
            _stockInfo.Euro = rnd.Next(30, 50);
            NotifyObservers();
        }
    }
}