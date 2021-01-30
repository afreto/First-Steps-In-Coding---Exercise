using System;

namespace _02._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете ъгъл в радиани(rad) и го преобразува в градуси(deg).
            double rad = double.Parse(Console.ReadLine());
            //Използвайте формулата: градус = радиан * 180 / π. Числото π в C# програми е достъпно чрез Math.PI.
            double deg = rad * 180 / Math.PI;

            //Закръглете резултата до най-близкото цяло число използвайки Math.Round().
            deg = Math.Round(deg);
            Console.WriteLine(deg);
        }
    }
}
