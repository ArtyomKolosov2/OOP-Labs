using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB2 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskB2(extract.IndividualB2());
        }
        public string GetInfo()
        {
            return "An application that outputs a string describing the score corresponding to the number M:";
        }

        public static string IndividualTaskB2(int mark)
        {
            var numbers = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            if (mark < 0 && mark > 10)
            {
                throw new ArgumentException("Error, invalid data.Transfer data from 0 to 10");
            }
            var res = string.Empty;
            if (mark >= numbers[0] && mark < numbers[2])
            {
                res = "Very bad";
            }
            else if (mark > numbers[2] && mark <= numbers[4])
            {
                res = "Unsatisfactory";
            }
            else if (mark > numbers[4] && mark <= numbers[6])
            {
                res = "Satisfactory";
            }
            else if (mark > numbers[6] && mark <= numbers[8])
            {
                res = "Good";
            }
            else if (mark > numbers[8] && mark <= numbers[10])
            {
                res = "Perfect";
            }
            return $"Mark is {res}";
        }
    }
}