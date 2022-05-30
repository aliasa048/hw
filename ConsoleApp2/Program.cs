using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

        { 
            cars car = new cars();
            car.brend = "gmc";
            car.model = "suburban";
            car.currentfule = 100;
            car.fuelfor1km = 1;
            car.millage = 20;

            car.Drive(10);
         
        } 
        
    }
}
