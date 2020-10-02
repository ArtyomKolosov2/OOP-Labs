using System;
using Lab_2_new.Tasks;

namespace Lab_2_new
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                IOservice.ShowMessage
                    (
                    "1 - TaskOne (conversion from grams)\n" +
                    "2 - TaskTwo (converting bytes to kilo, mega, Giga)\n" +
                    "3 - TaskThree (Centimeters to meters and kilometers)\n" +
                    "4 - TaskFour (Swap values of variables without using an additional variable)\n" +
                    "5 - TaskFive (the ratio of the cost of 1 kg of candy to 1 kg of gelatine)\n" +
                    "exit - Exit the program"
                    );
                string command = IOservice.GetUserInputStr();
                switch (command)
                {
                    case "1":
                        Task1.StartTask();
                        break;
                    case "2":
                        Task2.StartTask();
                        break;
                    case "3":
                        Task3.StartTask();
                        break;
                    case "4":
                        Task4.StartTask();
                        break;
                    case "5":
                        Task5.StartTask();
                        break;
                    case "exit":
                        return;                        
                    default:
                        IOservice.ShowMessage("Unknown command");
                        break;
                }
            }
            
        }
        
    }
}
