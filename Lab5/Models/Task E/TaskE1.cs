using Lab5.Interfaces;
using Lab5.Utils;
using System;

namespace Lab5.Models.Task_E
{
    public class TaskE1 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Finds fibonachi at some position";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out int number, "Input number:") && number > 0)
            {
                taskResult = $"Fibonachi number at position {number} = {FindFibonachi(number)}";
            }
            else
            {
                taskResult = $"Input Error!";
            }
            return taskResult;
        }
        public static int FindFibonachi(int position)
        {
            if (position < 0)
            {
                throw new ArgumentException("Position in sequence is lower than zero!", nameof(position));
            }
            var a = 0;
            var b = 1;
            var index = 0;
            var result = 0;
            while (index < position)
            {
                result = a;
                a = b;
                b += result;
                index++;
            }
            return result;
        }
    }
}
