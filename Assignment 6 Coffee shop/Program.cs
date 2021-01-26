using System;

namespace Assignment_6_Coffee_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink[] drinks = new Drink[10];

            drinks[0] = new Drink("coffee", 50);
            drinks[1] = new Drink("tea", 45);
            drinks[2] = new Drink("juice", 30);
            drinks[3] = new Drink("coffee", 50);

            for (int i = 0; i < drinks.Length; i++)
            {
                if (drinks[i] == null)
                {
                    Console.WriteLine(i = " has nothing there");
                }
                
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
