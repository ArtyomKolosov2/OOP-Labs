using Lab5.Interfaces;
using Lab5.Utils;
using System;

namespace Lab5.Models.Task_A
{
    public class TaskA2 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Counts sum of numbers in another number";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out int number, "Input number:"))
            {
                taskResult = $"Sum of numbers in {number} = {GetSumOfNumbers(number)}";
            }
            else
            {
                taskResult = $"Input Error!";
            }
            return taskResult;
        }
        public static int GetSumOfNumbers(int originalNumber)
        {
            var sum = 0;
            originalNumber = Math.Abs(originalNumber);
            while (originalNumber > 0)
            {
                var nextNumber = originalNumber % 10;
                sum += nextNumber;
                originalNumber /= 10;
            }
            return sum;
        }
    }
}
