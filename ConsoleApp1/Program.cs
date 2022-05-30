using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook Notebook1 = new Notebook();

            Notebook1.name = "asus";
            Notebook1.brendname = "tuf";
            Notebook1.price = 222;


            Console.WriteLine(Notebook1.name);
            Console.WriteLine(Notebook1.brendname);
            Console.WriteLine(Notebook1.price);

            Notebook[] notebooks = new Notebook[2];
             
            notebooks[0].name = "asus";
            notebooks[0].brendname = "tuf";
            notebook[0].price = 222;

            notebooks[1].name = "asda";
            notebooks[1].brendname = "asda";
            notebooks[1].price = 120;
            Console.WriteLine("Min Price daxil edin: ");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            Console.WriteLine("Max Price daxil edin: ");
            string strNew = Console.ReadLine();
            int b = Convert.ToInt32(strNew);

            for(int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i] >= a && notebooks[i] <= b)
                {
                    Console.WriteLine(notebooks[i].name);
                }
            }


        }
        

    } 
}
