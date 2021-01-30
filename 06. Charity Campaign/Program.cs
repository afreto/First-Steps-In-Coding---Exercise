using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfCake = 45;
            double priceOfWaffle = 5.80;
            double priceOfPancake = 3.20;
            int daysOfCampain = int.Parse(Console.ReadLine());
            int numOfWorkers = int.Parse(Console.ReadLine());
            int numOfCakes = int.Parse(Console.ReadLine());
            int numOfWaffles = int.Parse(Console.ReadLine());
            int numOfPancakes = int.Parse(Console.ReadLine());
            double sumPerDay = ((numOfCakes * priceOfCake) + (numOfWaffles * priceOfWaffle) + (numOfPancakes * priceOfPancake)) * numOfWorkers;
            double totalSumForCampain = sumPerDay * daysOfCampain;
            double productsCost = totalSumForCampain / 8;
            double totalSum = totalSumForCampain - productsCost;
            Console.WriteLine(totalSum);
        }
    }
}
