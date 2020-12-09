using Lab5.Interfaces;
using Lab5.Utils;
using System;

namespace Lab5.Models.Task_C
{
    public class TaskC2 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Finds out if the number is a palindrome";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out int number, "Input number:"))
            {
                taskResult = $"Is {number} a palindrome? = {IsPalindrome(number)}";
            }
            else
            {
                taskResult = $"Input Error!";
            }
            return taskResult;

        }
        public static bool IsPalindrome(int number)
        {
            number = Math.Abs(number);
            int reversedNumber = 0,
                remainder,
                originalNumber = number;

            while (number > 0)
            {
                remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }

    }
    
}
