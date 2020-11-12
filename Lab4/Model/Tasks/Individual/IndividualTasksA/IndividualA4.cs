using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Individual.IndividualTasksA
{
    class IndividualA4 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            int[] arrValue = extract.IndividualA4();
            int firstNumber = arrValue[0];
            int secondNumber = arrValue[1];
            return IndividualTaskA4(firstNumber, secondNumber);
        }
        public string GetInfo()
        {
            return "Emulated the Dice game:";
        }
        // Individual A4 - Dice
        public static string IndividualTaskA4(int firstNumber, int secondNumber)
        {
            //TODO fix extractor
            if (firstNumber < 0 && secondNumber < 0)
            {
                throw new Exception("Error, incorrect data.Input number more than 0");
            }
            return $"On the first die, it fell out - {firstNumber}\nOn the second die, it fell out - {secondNumber}\nResult = {firstNumber + secondNumber}";
        }
    }
}
