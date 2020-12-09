using Lab5.Interfaces;
using Lab5.Utils;
using System;

namespace Lab5.Models.Task_C
{
    public class TaskC1 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Finds out if the number contains a sequence";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out int number, "Input number:"))
            {
                taskResult = $"Is {number} contains sequence = {IsContainSequence(number)}";
            }
            else
            {
                taskResult = $"Input Error!";
            }
            return taskResult;

        }
        public static bool IsContainSequence(int originalNumber)
        {
            originalNumber = Math.Abs(originalNumber);
            var number = originalNumber % 10;
            int nextNumber = originalNumber;
            const int MAX_NATURAL_NUMBER = 0;
            var isGreater = false;
            var isLower = false;
            var result = true;

            while (nextNumber > 0 && nextNumber / 10 > MAX_NATURAL_NUMBER)
            {
                nextNumber /= 10;
                if (number > nextNumber % 10)
                {
                    if (isLower)
                    {
                        result = false;
                        break;
                    }
                    isGreater = true;
                }
                else if (number < nextNumber % 10)
                {
                    if (isGreater)
                    {
                        result = false;
                        break;
                    }
                    isLower = true;
                }
                else
                {
                    result = false;
                    break;
                }
                number = nextNumber % 10;
                
            }
            return result;
        }
    }
}
