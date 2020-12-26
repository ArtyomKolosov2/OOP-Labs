using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;
using System.Collections.Generic;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB9 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskB9(extract.IndividualB9());
        }
        public string GetInfo()
        {
            return "The program writes the number in English (Russian) words:";
        }
        
        public static Dictionary<int, string> YearsDict { get; } = new()
            {
                { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three"}, { 4, "four"}, { 5, "five" }, { 6, "six" }, { 7, "seven"}, { 8, "eight"}, { 9, "nine"},
                { 10, "ten"}, { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen"}, { 14, "fourteen"}, { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen"}, { 18, "eighteen"}, { 19, "nineteen"},
                { 20, "twenty"}, { 30, "thirty" }, { 40, "forty" }, { 50, "fifty" }, { 60, "sixty"}, { 70, "seventy" }, { 80, "eighty" }, { 90, "ninety" }, { 100, "hundred" }
            };
        public static string IndividualTaskB9(int number)
        {
            const int HUNDRED = 100,
                TWENTY = 20,
                TEN = 10;
            string resValue = string.Empty;
            if (number / HUNDRED > 0 && number / HUNDRED < TEN)// from 100 to 999
            {
                int hundreds = number / HUNDRED;
                int remains = number % HUNDRED;
                resValue += $"{YearsDict[hundreds]} {YearsDict[HUNDRED]}";
                if (remains / TEN > 0 && remains > TWENTY)// from 20 to 100
                {
                    resValue += $" {YearsDict[remains / TEN * TEN]} {YearsDict[remains % TEN]}";
                }
                else if (remains >= 0)// from 0 to 20
                {
                    resValue += $" {YearsDict[remains]}";
                }
                else
                {
                    throw new ArgumentException("Error, program was broken.Transfer number from 0 to 999");
                }
            }
            else if (number / TEN > 0 && number > TWENTY)// from 20 to 100
            {
                resValue = $"{YearsDict[number / TEN * TEN]}  {YearsDict[number % TEN]}";
            }
            else if (number >= 0)// from 0 to 20
            {
                resValue = YearsDict[number];
            }
            else
            {
                throw new ArgumentException("Error, program was broken.Transfer number from 0 to 999");
            }
            return resValue;
        }
    }
}
