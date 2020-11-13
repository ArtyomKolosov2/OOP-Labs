using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System.Linq;

namespace Lab4.Model.Tasks.Common
{
    class Common3 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return CommonTask3(extract.Common3());
        }
        public string GetInfo()
        {
            return "Determine whether a given number is a multiple of the corresponding numbers 2, 3, 5, 7, 11, 13, 17 and 19.";
        }
        // The number is a multiple of numbers: 2, 3, 5, 7, 11, 13, 17 и 19:
        public static string CommonTask3(int number)
        {
            return $"The number is a multiple of numbers: 2, 3, 5, 7, 11, 13, 17, 19 = {new int[] { 2, 3, 5, 7, 11, 13, 17, 19 }.Any(n => number % n == 0)}";
        }
    }
}
