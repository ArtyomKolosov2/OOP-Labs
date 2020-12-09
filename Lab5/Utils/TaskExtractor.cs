using Lab5.Interfaces;
using System;
using System.Collections.Generic;

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

        public bool GetNumber(out int number, string message)
        {
            _outputService.ShowMessage(message);
            return int.TryParse(_inputService.GetString(), out number);
        }

        public bool GetNumber(out int number, IEnumerable<string> messages)
        {
            foreach (var message in messages)
            {
                _outputService.ShowMessage(message);
            }
            return int.TryParse(_inputService.GetString(), out number);
        }
    }
}
