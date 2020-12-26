using Lab5.Interfaces;
using Lab5.Utils;
using System;

namespace Lab5.Models.Task_A
{
    public class TaskA5 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Counts amount of even number in another number (A5)";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out int number, "Input number:"))
            {
                taskResult = $"Amount of even number in {number} = {GetAmountOfEvenNumber(number)}";
            }
            else
            {
                taskResult = $"Input Error!";
            }
            return taskResult;
        }
        public static int GetAmountOfEvenNumber(int originalNumber)
        {
            var count = 0;
            originalNumber = Math.Abs(originalNumber);
            while (originalNumber > 0)
            {
                var nextNumber = originalNumber % 10;
                if (nextNumber % 2 == 0)
                {
                    count++;
                }
                originalNumber /= 10;
            }
            return count;
        }
    }
}
