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
            IOservice.ShowMessage("Input cantimetres: ");
            if (long.TryParse(IOservice.GetUserInputStr(), out long SM))
            {
                IOservice.ShowMessage
                (
                   $"Metres {ConvertDistance(SM, DistanceCoef.inMetr)} to {SM} cm\n" +
                   $"Kilometres {ConvertDistance(SM, DistanceCoef.inKilometr)} to {SM} сm\n" 
                );
            }
            else
            {
                IOservice.ShowMessage("Error!");
            }
        }
        public static double ConvertDistance(long SM, DistanceCoef coef)
        {
            return SM / (int)coef;
        }
    }
}
