using System;

namespace VisitorMetanit
{
    class XmlVisitor : IVisitor
    {
        public void VisitPersonAcc(Person acc)
        {
            string result = "<Person><Name>"+acc.Name+"</Name>"+
                            "<Number>"+acc.Number+"</Number><Person>";
            Console.WriteLine(result);
        }
 
        public void VisitCompanyAc(Company acc)
        {
            string result = "<Company><Name>" + acc.Name + "</Name>" + 
                            "<RegNumber>" + acc.RegNumber + "</RegNumber>" + 
                            "<Number>" + acc.Number + "</Number><Company>";
            Console.WriteLine(result);
        }
    }
}