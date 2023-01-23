using System;

namespace FlyweightMetanit
{
    internal class PanelHouse : House 
    {
        public PanelHouse()
        {
            Stages = 16;
        }
 
        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine("Построен панельный дом из 16 этажей; координаты: {0} широты и {1} долготы", 
                latitude, longitude);
        }
    }
}