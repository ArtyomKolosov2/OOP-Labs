using Lab6.Interfaces;
using Lab6.Utils;
using Lab6.Views;
using System;
using System.Linq;

namespace Lab6.Models.Individual
{
    public class TaskIndividual1 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "The sum of the negative elements of the vector and the product of the elements of the vector located between the maximum and minimum elements.";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            string taskResult;
            if (extractor.GetNumber(out var arrSize, "Input array size:"))
            {
                var arr = extractor.GetRandomDoubleEnumerable(arrSize).ToArray();
                taskResult = string.Concat
                (
                    $"{OutputService.ConvertIEnumerableToString(arr)} \nThe sum of the negative elements =",
                    $"{FindSumNegativeElements(arr)}\n",
                    $"The product of the elements of the vector located between the maximum and minimum elements. =",
                    $"{FindMultiplyOfElementsBetweenMaxAndMin(arr)}"
                );

            }
            else
            {
                taskResult = "Input error: Invalid array size!";
            }
            return taskResult;
        }

        public static double FindMultiplyOfElementsBetweenMaxAndMin(double[] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr), "Source array was null");
            }
            if (!arr.Any())
            {
                throw new ArgumentException("Source array was empty");
            }
            var minIndex = Array.IndexOf(arr, arr.Min());
            var maxIndex = Array.IndexOf(arr, arr.Max());
            Range range;
            if (minIndex < maxIndex)
            {
                range = (minIndex + 1)..maxIndex;

            }
            else if (minIndex > maxIndex)
            {
                range = (maxIndex + 1)..minIndex;
            }
            
            else
            {
                range = 0..arr.Length;
            }
            double result = 0;

            if (range.Start.Value != range.End.Value)
            {
                result = arr[range].Aggregate((p, x) => p *= x);
            }

            return result;
        }
        public static double FindSumNegativeElements(double[] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr), "Source array was null");
            }
            if (!arr.Any())
            {
                throw new ArgumentException("Source array was empty");
            }
            return arr.Where(el => el < 0).Sum();
        }
    }
}
