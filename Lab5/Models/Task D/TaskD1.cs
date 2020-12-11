using Lab5.Interfaces;
using Lab5.Utils;
using System;
using System.Collections.Generic;

namespace Lab5.Models.Task_D
{
    public class TaskD1 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Finds the largest number in another number";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out int number, "Input number:"))
            {
                taskResult = $"Max number in {number} = {FindOriginalNumberCount(number)}";
            }
            else
            {
                taskResult = $"Input Error!";
            }
            return taskResult;
        }
        public static int FindOriginalNumberCount(int originalNumber)
        {
            if (originalNumber == 0)
            {
                return 1;
            }
            var count = 0;
            const int NUMBER_LIST_SIZE = 10;
            originalNumber = Math.Abs(originalNumber);
            var foundNumbers = new List<int>(NUMBER_LIST_SIZE);
            while (originalNumber > 0)
            {
                int nextNumber = originalNumber % 10;
                if (!foundNumbers.Contains(nextNumber))
                {
                    foundNumbers.Add(nextNumber);
                    count++;
                }
                originalNumber /= 10;
            }
            return count;
        }
    }
}
