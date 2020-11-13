using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Utils.MyConverter;
using Lab4.Views;
using System;
using System.Collections.Generic;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB7 : ITask, ITaskInfo
    {
        private static Dictionary<string, Func<double, double, double>> OperationsDict { get; set; } = new Dictionary<string, Func<double, double, double>>
        {
            {"+", new Func<double, double, double>((x1, x2) => x1 + x2)},
            {"-", new Func<double, double, double>((x1, x2) => x1 - x2)},
            {"*", new Func<double, double, double>((x1, x2) => x1 * x2)},
            {"/", new Func<double, double, double>((x1, x2) => x1 / x2)}
        };
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());

            int[] arrValue = extract.IndividualB7();
            string operation = arrValue[0].ToString();
            int number1 = arrValue[1],
                number2 = arrValue[2];
            return IndividualTaskB7(operation, number1, number2);
        }
        public string GetInfo()
        {
            return "A program that accepts an operation and two real numbers from the user, and then performs the specified action on these numbers and outputs the result";
        }
        public static string IndividualTaskB7(string operation, int number1, int number2)
        {
            return OperationsDict[operation]?.Invoke(number1, number2).ToString();
        }
    }
}
