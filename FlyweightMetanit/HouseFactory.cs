using System.Collections.Generic;

namespace FlyweightMetanit
{
    internal class HouseFactory
    {
        private readonly Dictionary<string, House> _houses = new Dictionary<string, House>();
        
        public HouseFactory()
        {
            _houses.Add("Panel", new PanelHouse());
            _houses.Add("Brick", new BrickHouse());
        }
 
        public House GetHouse(string key)
        {
            return _houses.ContainsKey(key) ? _houses[key] : null;
        }
    }
}