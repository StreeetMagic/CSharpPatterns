namespace T04
{
    internal class DragonSlave : Spell
    {
        public DragonSlave(Area 
            castStrategy, 
            string name, 
            int cost, 
            ICost icost, 
            Hero hero) 
            : base(
                castStrategy, 
                name, 
                cost, 
                icost, 
                hero)
        {
        }
    }
}