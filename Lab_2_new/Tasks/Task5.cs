using System;

namespace Lab_2_new.Tasks
{
    public static class Task5
    {
        public static void StartTask()
        {
            IOservice.ShowMessage("How much does one kilogram of jelly beans cost in relation to sweets:");
            var XinKg = 15.5;
            var YinKg = 3.5;
            var X = 1d;
            var Y = 1d;
            IOservice.ShowMessage($"How much does 1 kg of candy cost  {X * XinKg}");

            IOservice.ShowMessage($"How much does 1 kg of gelatine cost  {Y * YinKg}");

            IOservice.ShowMessage("Enter the number of candies(kg)");
            X = Convert.ToDouble(IOservice.GetUserInputStr());
            IOservice.ShowMessage("Enter the number of jelly beans(kg)");
            Y = Convert.ToDouble(IOservice.GetUserInputStr());
            var A = X * XinKg;
            var B = Y * YinKg;

            IOservice.ShowMessage($"Х > Y : {Math.Round(FindMuchMore(X, Y, A, B), 2)}");
            IOservice.ShowMessage($"Y > X : {Math.Round(FindMuchMore(Y, X, B, A), 2)}");
        }
        private static double FindMuchMore(double X, double Y, double A, double B)
        {
            return (X / A) * B;
        }
    }
}
