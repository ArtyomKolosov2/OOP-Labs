using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB1 : ITask, ITaskInfo
    {
        public string Run()
        {
            var extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskB1((DayOfWeek)extract.IndividualB1());
        }
        public string GetInfo()
        {
            return "A program that displays the name of the corresponding day of the week according to the number:";
        }
        public static string IndividualTaskB1(DayOfWeek dayOfWeek)
        {
            return dayOfWeek switch
            {
                DayOfWeek.Monday => "Monday",
                DayOfWeek.Tuesday => "Tuesday",
                DayOfWeek.Wednesday => "Wednesday",
                DayOfWeek.Thursday => "Thursday",
                DayOfWeek.Friday => "Friday",
                DayOfWeek.Saturday => "Saturday",
                DayOfWeek.Sunday => "Sunday",
                _ => throw new ArgumentException("Unkonwn Error!"),
            };
        }
        
    }
}
