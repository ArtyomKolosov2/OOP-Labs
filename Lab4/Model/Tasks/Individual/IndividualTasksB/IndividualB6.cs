using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;
using System.Collections.Generic;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB6 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskB6(extract.IndividualB6());
        }
        public string GetInfo()
        {
            return "Displays the name of the corresponding time of year according to the day of the month:";
        }
        //TODO switch case
        public static string IndividualTaskB6(int numberMounth)
        {
            string resTimeYear = "";
            switch (numberMounth)
            {
                case 1:
                case 2:
                case 12:
                    resTimeYear = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    resTimeYear = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    resTimeYear = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    resTimeYear = "Autumn";
                    break;
                default:
                    throw new ArgumentException("Error, invalid data.");
                    break;
            };
            return resTimeYear;
        }
    }
}
