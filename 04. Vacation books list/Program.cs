using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вход
            //От конзолата се четат 3 реда:
            //⦁	Брой страници в текущата книга – цяло число в интервала[1…1000];
            int pages = int.Parse(Console.ReadLine());
            //⦁	Страници, които може да прочита за 1 час – реално число в интервала[1.00…1000.00];
            double pagesPerHour = double.Parse(Console.ReadLine());
            //⦁	Броя на дните, за които трябва да прочете книгата – цяло число в интервала[1…1000];
            int days = int.Parse(Console.ReadLine());
            //Изход
            //Да се отпечата на конзолата броят часове, които Жоро трябва да отделя за четене всеки ден.
            double pagesPerDay = pages / pagesPerHour;
            double neededHours = pagesPerDay / days;
            Console.WriteLine(neededHours);
        }
    }
}
