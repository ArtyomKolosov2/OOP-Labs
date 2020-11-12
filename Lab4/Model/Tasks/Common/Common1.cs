using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Common
{
    public class Common1 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return CommonTask1(extract.Common1());
        }
        public string GetInfo() 
        {
            return "Count of dragon heads and eyes:";
        }
        // Define count of dragon heads and eyes
        public static string CommonTask1(int year)
        {
            int startHead = 3, CoefUpTwoHundred = 3, CoefUpTreeHundred = 2;
            int TwoHundredYear = 200, TreeHundredYear = 300;

            int head;
            if (year < TwoHundredYear && year > 0)
            {
                head = year * CoefUpTwoHundred + startHead;
            }
            else if (year >= TwoHundredYear && year < TreeHundredYear)
            {
                head = TwoHundredYear * CoefUpTwoHundred + (year - TwoHundredYear) * CoefUpTreeHundred + startHead;
            }
            else if (year >= TreeHundredYear)
            {
                head = TwoHundredYear * CoefUpTwoHundred + (TreeHundredYear - TwoHundredYear) * CoefUpTreeHundred + (year - TreeHundredYear) + startHead;
            }
            else
            {
                throw new ArgumentException("Error, incorrect data, input number more than 0.");
            }
            int eyes = head * 2;
            return $"Count heads = {head}, count eyes = {eyes}";
        }
    }
}
