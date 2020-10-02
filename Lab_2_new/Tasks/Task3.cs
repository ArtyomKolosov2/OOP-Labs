using System;

namespace Lab_2_new.Tasks
{
    class Task3
    {
        public enum DistanceCoef
        {
            inMetr = 100,
            inKilometr = 100000,
        }
        public static void StartTask()
        {
            Console.WriteLine("Введите сантиметры: ");
            if (long.TryParse(Console.ReadLine(), out long SM))
            {
                Console.WriteLine
                (
                   $"Метров {ConvertDistance(SM, DistanceCoef.inMetr)} в {SM} см\n" +
                   $"Километров {ConvertDistance(SM, DistanceCoef.inKilometr)} в {SM} см\n" 
                );
            }
            else
            {
                Console.WriteLine("Error: число введено неправильно!");
            }
        }
        public static double ConvertDistance(long SM, DistanceCoef coef)
        {
            return SM / (int)coef;
        }
    }
}
