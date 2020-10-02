using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_new.Tasks
{
    public static class Task1
    {
        public enum MassCoef : int
        {
            Kilo = 1000,
            Centner = Kilo * 100,
            Ton = Kilo * 1000
        }
        public static void StartTask()
        {
            Console.WriteLine("Введите граммы: ");
            if (double.TryParse(Console.ReadLine(), out double grams))
            {
                Console.WriteLine
                (
                    $"Gramms = {grams}, \n" +
                    $"Kilo = {GetConvertionResult(grams, MassCoef.Kilo)}, \n" +
                    $"Centners = {GetConvertionResult(grams, MassCoef.Centner)}\n" +
                    $"Tons = {GetConvertionResult(grams, MassCoef.Ton)}\n"
                );
            }
            else
            {
                Console.WriteLine("Error: число введено неправильно!");
            }
        }

        static double GetConvertionResult(double grams, MassCoef coef)
        {
            return grams / (int)coef;
        }

    }
}
