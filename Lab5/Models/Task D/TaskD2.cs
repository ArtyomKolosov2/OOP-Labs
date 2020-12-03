using Lab5.Interfaces;
using Lab5.Utils;

namespace Lab5.Models.Task_D
{
    public class TaskD2 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Finds the largest number in another number";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            extractor.TaskD2(out int number);
            return $"Max number in {number} = {FindMaxNumber(number)}";

        }
        public int FindMaxNumber(int originalNumber)
        {
            int max = originalNumber % 10;
            while (originalNumber > 0)
            {
                int nextNumber = originalNumber % 10;
                if (nextNumber > max)
                {
                    max = nextNumber;
                }
                originalNumber /= 10;
            }
            return max;
        }
    }
}
