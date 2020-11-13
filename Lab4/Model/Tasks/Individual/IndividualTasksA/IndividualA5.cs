using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Individual.IndividualTasksA
{
    class IndividualA5 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskA5(extract.IndividualA5());
        }
        public string GetInfo()
        {
            return "Simulator of pies with a surprise:";
        }
        // Individual A5 - Simulator of pies with a surprise
        public static string IndividualTaskA5(int index)
        {
            string[] listSurprise = new string[]
            {    
                "Remember that every day is the first day of the rest of your life.",
                 "In life, there is a main thing and not the main thing, and we often spend our energy on trifles.",
                 "Not as good as I wanted, but not as bad as it could have been!",
                 "Do what you must, and come what may.People like to win.If you have not decided on the final goal, you have no chance of winning.",
                 "The downside of the crisis is new opportunities.",
                 "Not everyone can be your friend, but everyone can be your teacher.",
                 "If you truly want to be happy, learn to control your thoughts.",
                 "Everyone is entitled to as much happiness as he can give.",
                 "If you want to be successful, you have to look like you have it."
             };
            if (index < 0 && index > listSurprise.Length)
            {
                throw new ArgumentException("Error, incorrect data.Transfer number more than 0");
            }
            return listSurprise[index];
        }
    }
}
