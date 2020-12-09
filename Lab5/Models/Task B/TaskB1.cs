using Lab5.Interfaces;
using Lab5.Utils;
using System;

namespace Lab5.Models.Task_B
{
    public class TaskB1 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Finds if number contains only even numbers";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out int number, "Input number:"))
            {
                taskResult = $"Is {number} contains only even nums = {IsOnlyEvenInNums(number)}";
            }
            else
            {
                taskResult = $"Input Error!";
            }
            return taskResult;

        }
        public static bool IsOnlyEvenInNums(int originalNumber)
        {
            var result = true;
            originalNumber = Math.Abs(originalNumber);
            while (originalNumber > 0)
            {
                var nextNumber = originalNumber % 10;
                if (nextNumber % 2 != 0)
                {
                    result = false;
                    break;
                }
                
                originalNumber /= 10;
            }
            return result;
        }
    }
}
