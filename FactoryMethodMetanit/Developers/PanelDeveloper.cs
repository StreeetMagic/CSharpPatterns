using FactoryMethodMetanit.Houses;

namespace FactoryMethodMetanit.Developers
{
    internal class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        {
            
        }
 
        public override House Create()
        {
            return new PanelHouse();
        }
    }
}