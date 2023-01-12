using FactoryMethodMetanit.Houses;

namespace FactoryMethodMetanit.Developers
{
    internal class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        {
            
        }
 
        public override House Create()
        {
            return new WoodHouse();
        }
    }
}