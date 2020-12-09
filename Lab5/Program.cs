using Lab5.Controllers;
using Lab5.Interfaces;
using Lab5.Models.Task_A;
using Lab5.Models.Task_B;
using Lab5.Models.Task_C;
using Lab5.Models.Task_D;
using Lab5.Models.Task_E;
using Lab5.Utils;
using Lab5.Views;
using System.Collections.Generic;

namespace Lab5
{
    public static class Program
    {
        private static readonly IInputService _inputService = InputService.GetInstance();
        private static readonly IOutputService _outputService = OutputService.GetInstance();
        private static MainController MainController { get; set; }

        public static void Main()
        {
            List<ITaskResult> tasks = new ()
            {
                new TaskA5(),
                new TaskB5(),
                new TaskC1(),
                new TaskD2(),
                new TaskE1(),
                new TaskA2(),
                new TaskC2(),
                new TaskB1(),
                new TaskD1(),
                new TaskE2()
            };
            MainController = new MainController
            (
                tasks,
                _inputService,
                _outputService
            );
            MainController.StartController();
        }
    }
}
