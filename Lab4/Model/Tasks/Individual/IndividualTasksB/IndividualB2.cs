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

        //TODO Rebuild
        public static string IndividualTaskB2(int mark)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            const int Zero = 0,
                Two = 2,
                Four = 4,
                Six = 6,
                Eight = 8,
                Ten = 10;
            if (mark < Zero && mark > Ten)
            {
                throw new Exception("Error, invalid data.Transfer data from 0 to 10");
            }
            string res = "";
            if (mark >= numbers[Zero] && mark < numbers[Two])
            {
                res = "Very bad";
            }
            else if (mark > numbers[Two] && mark <= numbers[Four])
            {
                res = "Unsatisfactory";
            }
            else if (mark > numbers[Four] && mark <= numbers[Six])
            {
                res = "Satisfactory";
            }
            else if (mark > numbers[Six] && mark <= numbers[Eight])
            {
                res = "Good";
            }
            else if (mark > numbers[Eight] && mark <= numbers[Ten])
            {
                res = "Perfect";
            }
            return $"Mark is {res}";
        }
    }
}
