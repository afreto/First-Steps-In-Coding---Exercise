using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceOfStrawberry = double.Parse(Console.ReadLine());
            double amountOfBanana = double.Parse(Console.ReadLine());
            double amountOfOrange = double.Parse(Console.ReadLine());
            double amountOfRaspberriy = double.Parse(Console.ReadLine());
            double amountOfStrawberry = double.Parse(Console.ReadLine());
            double priceOfRaspberriy = priceOfStrawberry / 2;
            double priceOfOrange = priceOfRaspberriy - (priceOfRaspberriy * 0.40);
            double priceOfBanana = priceOfRaspberriy - (priceOfRaspberriy * 0.80);
            double totalSum = (amountOfStrawberry * priceOfStrawberry) + (amountOfBanana * priceOfBanana) + (amountOfOrange * priceOfOrange) + (amountOfRaspberriy * priceOfRaspberriy);
            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
