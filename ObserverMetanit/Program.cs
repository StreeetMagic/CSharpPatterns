using System;

namespace ObserverMetanit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Stock stock = new Stock();
            Bank bank = new Bank("ЮнитБанк", stock);
            Broker broker = new Broker("Иван Иваныч", stock);

            stock.Market();
            broker.StopTrade();
            stock.Market();

            Console.Read();
        }
    }
}