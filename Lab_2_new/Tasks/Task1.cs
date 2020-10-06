using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_new.Tasks
{
    public static class Task1
    {
        public static void StartTask()
        {
            IOservice.ShowMessage("Input grams: ");
            if (double.TryParse(IOservice.GetUserInputStr(), out double grams))
            {
                IOservice.ShowMessage
                (
                    $"Gramms = {grams}, \n" +
                    $"Kilo = {Converter.GetConvertionResult(grams, (int)ConvertCoefEnum.Kilo)}, \n" +
                    $"Centners = {Converter.GetConvertionResult(grams, (int)ConvertCoefEnum.Centner)}\n" +
                    $"Tons = {Converter.GetConvertionResult(grams, (int)ConvertCoefEnum.Ton)}\n"
                );
            }
            else
            {
                IOservice.ShowMessage("Error!");
            }
        }

        

    }
}
