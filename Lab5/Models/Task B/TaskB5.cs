using Lab5.Interfaces;
using Lab5.Utils;

namespace Lab5.Models.Task_B
{
    public class TaskB5 : ITaskResult, ITaskInfo
    {
        public string GetInfo()
        {
            return "Finds out whether even numbers prevail in another number";
        }
        public string GetTaskResult(TaskExtractor extractor)
        {
            extractor.TaskB5(out int number);
            return $"Is there more evens than odd in {number} = {IsEvenNumsPrevail(number)}";

        }
        public bool IsEvenNumsPrevail(int originalNumber)
        {
            int evenCount = 0;
            int oddCount = 0;
            while (originalNumber > 0)
            {
                int nextNumber = originalNumber % 10;
                if (nextNumber % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                originalNumber /= 10;
            }
            return evenCount > oddCount;
        }
    }
}
