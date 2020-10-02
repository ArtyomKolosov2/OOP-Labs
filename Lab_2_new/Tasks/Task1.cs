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
            IOservice.ShowMessage("Input grams: ");
            if (double.TryParse(IOservice.GetUserInputStr(), out double grams))
            {
                IOservice.ShowMessage
                (
                    $"Gramms = {grams}, \n" +
                    $"Kilo = {GetConvertionResult(grams, MassCoef.Kilo)}, \n" +
                    $"Centners = {GetConvertionResult(grams, MassCoef.Centner)}\n" +
                    $"Tons = {GetConvertionResult(grams, MassCoef.Ton)}\n"
                );
            }
            else
            {
                IOservice.ShowMessage("Error!");
            }
        }

        static double GetConvertionResult(double grams, MassCoef coef)
        {
            return grams / (int)coef;
        }

    }
}
