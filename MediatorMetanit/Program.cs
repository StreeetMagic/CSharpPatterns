using System;

namespace MediatorMetanit
{
    public static class Program
    {
        private static void Main()
        {
            ManagerMediator mediator = new ManagerMediator();
            Colleague customer = new CustomerColleague(mediator);
            Colleague programmer = new ProgrammerColleague(mediator);
            Colleague tester = new TesterColleague(mediator);
            
            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;
            
            customer.Send("Есть заказ, надо сделать программу");
            programmer.Send("Программа готова, надо протестировать");
            tester.Send("Программа протестирована и готова к продаже");
 
            Console.Read();
        }
    }
}