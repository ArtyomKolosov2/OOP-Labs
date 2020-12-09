using Lab5.Interfaces;
using Lab5.Utils;
using System;

namespace Lab5.Models.Task_B
{
    public class TaskB5 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Finds out whether even numbers prevail in another number";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out int number, "Input number:"))
            {
                taskResult = $"Is there more evens than odd in {number} = {IsEvenNumsPrevail(number)}";
            }
            else
            {
                taskResult = $"Input Error!";
            }
            return taskResult;

        }
        public static bool IsEvenNumsPrevail(int originalNumber)
        {
            var evenCount = 0;
            var oddCount = 0;
            originalNumber = Math.Abs(originalNumber);
            while (originalNumber > 0)
            {
                var nextNumber = originalNumber % 10;
                if (nextNumber % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                originalNumber /= 10;
            }
            return evenCount > oddCount;
        }
    }
}
