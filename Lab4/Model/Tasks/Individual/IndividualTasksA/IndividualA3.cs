using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Individual.IndividualTasksA
{
    class IndividualA3 : ITask, ITaskInfo
    {
        public static string BadMood { get; } = "͡Ò﹏Ó";
        public static string GoodMood { get; } = "¯＼_(ツ)_/¯";
        public static string PerfectMood { get; } = "(o˘◡˘o)";
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskA3(extract.IndividualA3());
        }
        public string GetInfo()
        {
            return "Emulates the user's mood.Two six-sided dice (dice) are thrown and the total amount of points that fell on the first and second dice is calculated:";
        }

        // Individual A3 - Mood sensor
        public static string IndividualTaskA3(int mood)
        {
            string smile = string.Empty;
            if (mood >= 0 && mood < 33)
            {
                smile = BadMood;
            }
            else if (mood >= 33 && mood < 66)
            {
                smile = GoodMood;
            }
            else if (mood >= 66)
            {
                smile = PerfectMood;
            }
            else
            {
                throw new ArgumentException("Error. Transfer number from 0 to 100");
            }
            return smile;
        }
    }
}
