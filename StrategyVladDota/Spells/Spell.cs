using System.Security.Permissions;

namespace T04
{
    public abstract class Spell : ICast, ICost
    {
        private readonly Hero _hero;
        
        private readonly ICast _castStrategy;
        private readonly ICost _icostItem;
        
        private readonly int _cost;

        protected Spell
        (
            ICast castStrategy,
            string name,
            int cost,
            ICost icost,
            Hero hero
        )
        {
            _castStrategy = castStrategy;
            _cost = cost;
            Name = name;
            _icostItem = icost;
            _hero = hero;
        }

        public string Name { get; }

        public void Cast()
        {
            _castStrategy.Cast();
            RemoveRecoucre(_hero, _cost);
        }

        public void RemoveRecoucre(Hero hero, int cost)
        {
            _icostItem.RemoveRecoucre(hero, cost);
        }
    }
}