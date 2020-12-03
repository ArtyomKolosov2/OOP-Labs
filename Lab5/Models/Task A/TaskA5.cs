using Lab4.Model.Tasks.Base;
using Lab5.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.Models.Task_A
{
    public class TaskA5 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Counts amount of even number in another number";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            extractor.TaskA5(out int number);
            return $"Amount of even number in {number} = {GetAmountOfEvenNumber(number)}";

        }
        public int GetAmountOfEvenNumber(int originalNumber)
        {
            int count = 0;
            while (originalNumber > 0)
            {
                int nextNumber = originalNumber % 10;
                if (nextNumber % 2 == 0)
                {
                    count++;
                }
                originalNumber /= 10;
            }
            return count;
        }
    }
}
