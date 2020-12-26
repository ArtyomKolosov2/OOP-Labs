using Lab6.Interfaces;
using Lab6.Utils;
using Lab6.Views;
using System;
using System.Linq;

namespace Lab6.Models.Individual
{
    public class TaskIndividual2 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "The maximum element of the vector and the sum of the elements of the vector located up to the last positive element.";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out var arrSize, "Input array size:"))
            {
                var arr = extractor.GetRandomDoubleEnumerable(arrSize).ToArray();

                OutputService.ConvertIEnumerableToString(arr);

                taskResult = string.Concat(
                    $"{OutputService.ConvertIEnumerableToString(arr)} \nThe sum of the negative elements =",
                    $"Max number in the vector = { arr.Max() }\n" +         
                    $"Sum elements before last positive = { Math.Round(SumElementsBeforeLastPositive(arr), 2) }");
            }
            else
            {
                taskResult = "Input error: Invalid array size!";
            }
            return taskResult;
        }
        public static double SumElementsBeforeLastPositive(double[] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr), "Source array was null");
            }
            if (!arr.Any())
            {
                throw new ArgumentException("Source array was empty");
            }
            var index = Array.IndexOf(arr, arr.LastOrDefault(x => x > 0));
            double result = 0;
            if (index > 0)
            {
                var array = arr[0..index];
                result = array.Sum();
            }
            return result;
        }
    }
}
