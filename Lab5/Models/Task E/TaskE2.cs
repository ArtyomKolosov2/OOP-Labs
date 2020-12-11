using Lab5.Interfaces;
using Lab5.Utils;
using Lab5.Views;
using System;
using System.Collections.Generic;

namespace Lab5.Models.Task_E
{
    public class TaskE2 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Finds part of fibonachi sequence";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out int number, new string[] {"Input number", "Input number must be greater than zero:" }) && number > 0)
            {
                taskResult = $"Fibonachi sequence = {OutputService.ConvertIEnumerableToString(FindFibonachiSequence(number))}";
            }
            else
            {
                taskResult = $"Input Error!";
            }
            return taskResult;
        }
        public static IEnumerable<int> FindFibonachiSequence(int position)
        {
            if (position < 0)
            {
                throw new ArgumentException("Position in sequence is lower than zero!", nameof(position));
            }
            var resultArray = new int[position];
            var a = 0;
            var b = 1;
            var index = 0;
            int currentFibonachiNumber;
            while (index < position)
            {
                currentFibonachiNumber = a;
                a = b;
                b += currentFibonachiNumber;
                resultArray[index] = currentFibonachiNumber;
                index++;
                
            }
            return resultArray;
        }
    }
}
