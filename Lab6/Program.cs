using Lab6.Controllers;
using Lab6.Interfaces;
using Lab6.Models.Individual;
using Lab6.Utils;
using Lab6.Views;
using System.Collections.Generic;

namespace Lab6
{
    public static class Program
    {
        private static readonly IInputService _inputService = InputService.GetInstance();
        private static readonly IOutputService _outputService = OutputService.GetInstance();
        private static MainController MainController { get; set; }

        public static void Main()
        {
            List<ITaskResult> tasks = new()
            {
                new TaskIndividual1(),
                new TaskIndividual2(),
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
