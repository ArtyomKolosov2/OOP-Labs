using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System.Linq;

namespace Lab4.Model.Tasks.Common
{
    class Common2 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return CommonTask2(extract.Common2());
        }
        public string GetInfo()
        {
            return "Determines which of the four etc. values entered by the user is the largest (smallest):";
        }
        public static string CommonTask2(int[] numbers)
        {
            string resValue = "";
            if (numbers.All(x => x == numbers[0]))
            {
                return "All values are equal.";
            }
            resValue = $"Max = {numbers.Max()}, Min = {numbers.Min()}";
            return resValue;
        }
    }
}
