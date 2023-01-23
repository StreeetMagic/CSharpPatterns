using System;

namespace FlyweightMetanit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            double longitude = 37.61;
            double latitude = 55.74;

            HouseFactory houseFactory = new HouseFactory();

            for (int i = 0; i < 5; i++)
            {
                House panelHouse = houseFactory.GetHouse("Panel");

                if (panelHouse != null)
                {
                    panelHouse.Build(longitude, latitude);
                }

                longitude += 0.1;
                latitude += 0.1;
            }

            for (int i = 0; i < 5; i++)
            {
                House brickHouse = houseFactory.GetHouse("Brick");

                if (brickHouse != null)
                {
                    brickHouse.Build(longitude, latitude);
                }

                longitude += 0.1;
                latitude += 0.1;
            }

            Console.Read();
        }
    }
}

//  https://metanit.com/sharp/patterns/4.7.php

