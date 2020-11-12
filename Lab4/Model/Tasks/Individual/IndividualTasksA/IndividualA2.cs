using Lab4.Model.Tasks.Base;
using Lab4.Utils;
using Lab4.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4.Model.Tasks.Individual.IndividualTasksA
{
    class IndividualA2 : ITask, ITaskInfo
    {
        //TODO const add
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            return IndividualTaskA2(extract.IndividualA2());
        }
        public string GetInfo()
        {
            return "Determined whether the entered letter is a vowel or consonant.";
        }
        private static string IsVowel1(char letter)
        {
            return new []{ 'a', 'e', 'i', 'o', 'u' }.Contains(letter) ? "Vowel": "Сonsonant";
        }
        private static string IsVowel2(char letter)
        {
            string letterType = string.Empty;
            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    letterType = "Vovel";
                    break;
                default:
                    letterType = "Consonant";
                    break;
            }
            return letterType;
        }
        private static string IsVowel3(char letter)
        {
            return (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') ? "Vowel" : "Сonsonant";
        }

        private static string IsVowel4(char letter)
        {
            return new[] { 'a', 'e', 'i', 'o', 'u' }.Any(x => x == letter) ? "Vowel" : "Сonsonant";
        }
        // Individual A2
        public static string IndividualTaskA2(string userStr)
        {
            if (userStr == null)
            {
                throw new InvalidOperationException("Error, incorrect data.Transfer letter!");
            }
            char letter = userStr[0];
            return $"{IsVowel1(letter)}\n{IsVowel2(letter)}\n{IsVowel3(letter)}";
        }
    }
}
