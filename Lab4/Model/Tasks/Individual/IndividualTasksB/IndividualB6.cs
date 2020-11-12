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
            const int One = 1,
                Three = 3,
                Six = 6,
                Nine = 9,
                Twelve = 12;
            string resTimeYear = "";
            if (numberMounth >= One && numberMounth < Three || numberMounth == Twelve)
            {
                resTimeYear = "Winter";
            }
            else if (numberMounth >= Three && numberMounth < Six)
            {
                resTimeYear = "Spring";
            }
            else if (numberMounth >= Six && numberMounth < Nine)
            {
                resTimeYear = "Summer";
            }
            else if (numberMounth >= Nine && numberMounth < Twelve)
            {
                resTimeYear = "Autumn";
            }
            else
            {
                throw new Exception("Error, invalid data.");
            }
            return resTimeYear;
        }
    }
}
