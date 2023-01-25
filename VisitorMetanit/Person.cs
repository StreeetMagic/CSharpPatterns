namespace VisitorMetanit
{
    internal class Person : IAccount
    {
        public string Name { get; set; }
        public string Number { get; set; }
 
        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }
    }
}