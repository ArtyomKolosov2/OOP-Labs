using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;

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
        string zodiacSign = string.Empty;
        if (mounth == 1)
        {
            if (day < 21) { zodiacSign = "Capricorn"; } else { zodiacSign = "Aquarius"; }
        }
        else if (mounth == 2)
        {
            if (day < 19) { zodiacSign = "Aquarius"; } else { zodiacSign = "Fish"; }
        }
        else if (mounth == 3)
        {
            if (day < 21) { zodiacSign = "Fish"; } else { zodiacSign = "Aries"; }
        }
        else if (mounth == 4)
        {
            if (day < 20) { zodiacSign = "Aries"; } else { zodiacSign = "Taurus"; }
        }
        else if (mounth == 5)
        {
            if (day < 21) { zodiacSign = "Taurus"; } else { zodiacSign = "Twins"; }
        }
        else if (mounth == 6)
        {
            if (day < 21) { zodiacSign = "Twins"; } else { zodiacSign = "Cancer"; }
        }
        else if (mounth == 7)
        {
            if (day < 23) { zodiacSign = "Cancer"; } else { zodiacSign = "Lion"; }
        }
        else if (mounth == 8)
        {
            if (day < 23) { zodiacSign = "Lion"; } else { zodiacSign = "Maid"; }
        }
        else if (mounth == 9)
        {
            if (day < 23) { zodiacSign = "Maid"; } else { zodiacSign = "Scales"; }
        }
        else if (mounth == 10)
        {
            if (day < 23) { zodiacSign = "Scales"; } else { zodiacSign = "Scorpio"; }
        }
        else if (mounth == 11)
        {
            if (day < 23) { zodiacSign = "Scorpio"; } else { zodiacSign = "Sagittarius"; }
        }
        else if (mounth == 12)
        {
            if (day < 21) { zodiacSign = "Sagittarius"; } else { zodiacSign = "Capricorn"; }
        }
        else
        {
            throw new ArgumentException("Error, incorrect data");
        }
        return $"The zodiac sign is - {zodiacSign}";
    }
}