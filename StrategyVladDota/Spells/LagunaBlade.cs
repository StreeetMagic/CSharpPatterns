namespace T04
{
    internal class LagunaBlade : Spell
    {
        public LagunaBlade(
            
            SingleTarget castStrategy, 
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