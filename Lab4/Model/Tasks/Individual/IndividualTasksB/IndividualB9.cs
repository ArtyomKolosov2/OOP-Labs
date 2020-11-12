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

        //TODO replace concat
        public static string IndividualTaskB9(int number)
        {
            Dictionary<int, string> dictYears = new Dictionary<int, string>
            {
                { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three"}, { 4, "four"}, { 5, "five" }, { 6, "six" }, { 7, "seven"}, { 8, "eight"}, { 9, "nine"},
                { 10, "ten"}, { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen"}, { 14, "fourteen"}, { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen"}, { 18, "eighteen"}, { 19, "nineteen"},
                { 20, "twenty"}, { 30, "thirty" }, { 40, "forty" }, { 50, "fifty" }, { 60, "sixty"}, { 70, "seventy" }, { 80, "eighty" }, { 90, "ninety" }, { 100, "hundred" }
            };
            const int Hundred = 100,
                Twenty = 20,
                Ten = 10;
            string resValue = "";
            if (number / Hundred > 0 && number / Hundred < Ten)// from 100 to 999
            {
                int hundreds = number / Hundred;
                int remains = number % Hundred;
                resValue += dictYears[hundreds] + " " + dictYears[Hundred];
                if (remains / Ten > 0 && remains > Twenty)// from 20 to 100
                {
                    int ten = remains / Ten;
                    int digit = remains % Ten;
                    resValue += " " + dictYears[ten * Ten] + " " + dictYears[digit];
                }
                else if (remains >= 0)// from 0 to 20
                {
                    resValue += " " + dictYears[remains];
                }
                else
                {
                    throw new Exception("Error, program was broken.Transfer number from 0 to 999");
                }
            }
            else if (number / Ten > 0 && number > Twenty)// from 20 to 100
            {
                int tens = number / Ten;
                int digit = number % Ten;
                resValue = dictYears[tens * Ten] + " " + dictYears[digit];
            }
            else if (number >= 0)// from 0 to 20
            {
                resValue = dictYears[number];
            }
            else
            {
                throw new Exception("Error, program was broken.Transfer number from 0 to 999");
            }
            return resValue;
        }
    }
}
