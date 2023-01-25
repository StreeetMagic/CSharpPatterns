using System.Collections.Generic;

namespace VisitorMetanit
{
    internal class Bank
    {
        private readonly List<IAccount> _accounts = new List<IAccount>();
        
        public void Add(IAccount acc)
        {
            _accounts.Add(acc);
        }
        
        public void Remove(IAccount acc)
        {
            _accounts.Remove(acc);
        }
        
        public void Accept(IVisitor visitor)
        {
            foreach (IAccount account in _accounts)
                account.Accept(visitor);
        }
    }
}