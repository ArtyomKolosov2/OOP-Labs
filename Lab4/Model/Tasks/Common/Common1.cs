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
        private static int CountEyes(int head)
        {
            return head * 2;
        }
        // TODO rename const
        private static int CountHeads(int years)
        {
            const int STARTHEAD = 3, COEFTWOHUNDRED = 3, coefUpTreeHundred = 2;
            const int twoHundredYear = 200, threeHundredYear = 300;
            int head = 0;
            if (years < twoHundredYear && years > 0)
            {
                head = years * COEFTWOHUNDRED + STARTHEAD;
            }
            else if (years >= twoHundredYear && years < threeHundredYear)
            {
                head = twoHundredYear * COEFTWOHUNDRED + (years - twoHundredYear) * coefUpTreeHundred + STARTHEAD;
            }
            else if (years >= threeHundredYear)
            {
                head = twoHundredYear * COEFTWOHUNDRED + (threeHundredYear - twoHundredYear) * coefUpTreeHundred + (years - threeHundredYear) + STARTHEAD;
            }
            else
            {
                throw new ArgumentException("Error, incorrect data, input number more than 0.");
            }
            return head;
        }
        // Define count of dragon heads and eyes
        public static string CommonTask1(int years)
        {
            int heads = CountHeads(years);
            return $"Count heads = {heads}, count eyes = {CountEyes(heads)}";
        }
    }
}
