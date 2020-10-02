using System;
using Lab_2_new.Tasks;

namespace Lab_2_new
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool IsRunning = true;
            while (IsRunning)
            {
                Console.WriteLine
                    (
                    "1 - TaskOne (Конвертация из граммов)\n"+
                    "2 - TaskTwo (Конвертация байтов в кило, мега, гига)\n" +
                    "exit - Выход из программы"
                    );
                string command = Console.ReadLine();
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
                    case "exit":
                        IsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
            
        }
        
    }
}
