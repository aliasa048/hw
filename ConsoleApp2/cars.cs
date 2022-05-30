using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class cars
        
    {
        public string brend;
        public string model;
        public int currentfule;
        public int fuelfor1km;
        public int millage;
        
        public void Drive(int km)
        {
            if(currentfule / fuelfor1km >= km)
            {
                millage -= km;
                currentfule -= km * fuelfor1km;
            }
            else
            {
                Console.WriteLine("Yetəri qədər benzin yoxdur.");
            }
        }

    }
}
