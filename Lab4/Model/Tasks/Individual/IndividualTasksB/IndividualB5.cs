﻿using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB5 : ITask, ITaskInfo
    {
        static readonly int[] arrCountDayInMounth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public string Run()
        {
            var extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());

            uint[] arrValue = extract.IndividualB5();
            uint year = arrValue[0],
                mounth = arrValue[1];
            return IndividualTaskB5(mounth, year);
        }
        public string GetInfo()
        {
            return "Defines the number of days in this month for a non-leap year:";
        }
        // count of day in mount for not a leap year
        private static bool IsLeep(uint year)
        {
            return year % 4 == 0 || (year % 4 == 0 && year % 100 == 0 && year % 400 == 0);
        }
        public static string IndividualTaskB5(uint mounth, uint year)
        {
            string resData;
            if (IsLeep(year))
            {
                resData = "Year is leep!";
            }
            else
            {
                resData = $"In {mounth} mounth - { arrCountDayInMounth[--mounth] } days";
            }
            return resData;
        }
    }
}
