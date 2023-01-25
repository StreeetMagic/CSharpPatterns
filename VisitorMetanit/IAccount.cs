namespace VisitorMetanit
{
    interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}