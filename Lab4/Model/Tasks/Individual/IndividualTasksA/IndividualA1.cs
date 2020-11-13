using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Individual.IndividualTasksA
{
    class IndividualA1 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            double[] arrValue = extract.IndividualA1();
            double aSide = arrValue[0];
            double bSide = arrValue[1];
            double cSide = arrValue[2];
            return IndividualTaskA1(aSide, bSide, cSide);
        }
        public string GetInfo()
        {
            return "Determines whether the given sides are sides of a triangle.";
        }
        // Individual A1
        //TODO FIX LOGIC
        private static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c || b + c > a || a + c > b;
        }
        public static string IndividualTaskA1(double aSide, double bSide, double cSide)
        {
            if (aSide < 0 || bSide < 0 || cSide < 0)
            {
                throw new ArgumentException("Error, incorrect data.Transfer number more than 0");
            }
            return "Is these sides are sides of a triangle - " + IsTriangle(aSide, bSide, cSide);
        }
    }
}