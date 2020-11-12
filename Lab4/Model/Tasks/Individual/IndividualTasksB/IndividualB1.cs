using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;
using System.Collections.Generic;
namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB1 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskB1(extract.IndividualB1());
        }
        public string GetInfo()
        {
            return "A program that displays the name of the corresponding day of the week according to the number:";
        }
        //TODO Replace with Enum
        public static string IndividualTaskB1(int dayOfWeek)
        {
            List<string> listDayOfWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int StartRange = 1, EndRange = 7;
            if (dayOfWeek >= StartRange && dayOfWeek <= EndRange)
            {
                return $"Today is - {listDayOfWeek[dayOfWeek - 1]}";
            }
            else
            {
                throw new Exception("Error, incorrect data.Transfer number from 1 to 7");
            }
        }
    }
}
