using Lab5.Interfaces;
using Lab5.Utils;
using System;

namespace Lab5.Models.Task_D
{
    public class TaskD2 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Find the number of different digits of a given natural number";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out int number, "Input number:"))
            {
                taskResult = $"Count of original mubers in {number} = {FindMaxNumber(number)}";
            }
            else
            {
                taskResult = $"Input Error!";
            }
            return taskResult;
        }
        public static int FindMaxNumber(int originalNumber)
        {
            originalNumber = Math.Abs(originalNumber);
            var max = originalNumber % 10;
            while (originalNumber > 0)
            {
                var nextNumber = originalNumber % 10;
                if (nextNumber > max)
                {
                    max = nextNumber;
                }
                originalNumber /= 10;
            }
            return max;
        }
    }
}
