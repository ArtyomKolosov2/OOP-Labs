using Lab5.Interfaces;
using System;

namespace Lab5.Utils
{
    public class TaskExtractor
    {
        private readonly IOutputService _outputService;
        private readonly IInputService _inputService;
        public TaskExtractor(IOutputService outputService, IInputService inputService)
        {
            _outputService = outputService;
            _inputService = inputService;
        }

        public bool TaskA5(out int number)
        {
            _outputService.ShowMessage("Task A5 input");
            _outputService.ShowMessage("Input number:");
            return int.TryParse(_inputService.GetString(), out number);
        }

        public bool TaskB5(out int number)
        {
            _outputService.ShowMessage("Task B5 input");
            _outputService.ShowMessage("Input number:");
            return int.TryParse(_inputService.GetString(), out number);
        }

        public bool TaskC1(out int number)
        {
            _outputService.ShowMessage("Task C1 input");
            _outputService.ShowMessage("Input number:");
            return int.TryParse(_inputService.GetString(), out number);
        }
        public bool TaskD2(out int number)
        {
            _outputService.ShowMessage("Task D2 input");
            _outputService.ShowMessage("Input number:");
            return int.TryParse(_inputService.GetString(), out number);
        }
    }
}
