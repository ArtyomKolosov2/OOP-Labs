using Lab5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void TaskA5(out int number)
        {
            _outputService.ShowMessage("Input number:");
            number = Convert.ToInt32(_inputService.GetString());
        }
    }
}
