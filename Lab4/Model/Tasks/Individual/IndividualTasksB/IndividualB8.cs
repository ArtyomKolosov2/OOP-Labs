using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB8 : ITask, ITaskInfo
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            int[] arrValue = extract.IndividualB8();
            int day = arrValue[0],
                mounth = arrValue[1];
            return IndividualTaskB8(day, mounth);
        }
        public string GetInfo()
        {
            return "A program that outputs the Zodiac sign corresponding to this date: \"Aquarius\" (20.1-18.2):";
        }
        public static string IndividualTaskB8(int day, int mounth)
        {

            const int TwentyThree = 23,
                TwentyTwo = 22,
                TwentyOne = 21,
                Twenty = 20,
                Nineteen = 19;
            string zodiacSign = "";
            switch (mounth)
            {
                case 1:
                    if (day < TwentyOne) { zodiacSign = "Capricorn"; } else { zodiacSign = "Aquarius"; }
                    break;
                case 2:
                    if (day < Nineteen) { zodiacSign = "Aquarius"; } else { zodiacSign = "Fish"; }
                    break;
                case 3:
                    if (day < TwentyOne) { zodiacSign = "Fish"; } else { zodiacSign = "Aries"; }
                    break;
                case 4:
                    if (day < Twenty) { zodiacSign = "Aries"; } else { zodiacSign = "Taurus"; }
                    break;
                case 5:
                    if (day < TwentyOne) { zodiacSign = "Taurus"; } else { zodiacSign = "Twins"; }
                    break;
                case 6:
                    if (day < TwentyTwo) { zodiacSign = "Twins"; } else { zodiacSign = "Cancer"; }
                    break;
                case 7:
                    if (day < TwentyThree) { zodiacSign = "Cancer"; } else { zodiacSign = "Lion"; }
                    break;
                case 8:
                    if (day < TwentyThree) { zodiacSign = "Lion"; } else { zodiacSign = "Maid"; }
                    break;
                case 9:
                    if (day < TwentyThree) { zodiacSign = "Maid"; } else { zodiacSign = "Scales"; }
                    break;
                case 10:
                    if (day < TwentyThree) { zodiacSign = "Scales"; } else { zodiacSign = "Scorpio"; }
                    break;
                case 11:
                    if (day < TwentyThree) { zodiacSign = "Scorpio"; } else { zodiacSign = "Sagittarius"; }
                    break;
                case 12:
                    if (day < TwentyTwo) { zodiacSign = "Sagittarius"; } else { zodiacSign = "Capricorn"; }
                    break;
                default:
                    throw new Exception("Error, incorrect data");
            }
            return "The zodiac sign is - " + zodiacSign;
        }
    }
}
