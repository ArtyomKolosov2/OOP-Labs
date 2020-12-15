using Lab6.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab6.Utils
{
    public class TaskExtractor
    {
        private readonly Random _random;
        private readonly IOutputService _outputService;
        private readonly IInputService _inputService;
        public TaskExtractor(IOutputService outputService, IInputService inputService)
        {
            _outputService = outputService;
            _inputService = inputService;
            _random = new Random();
        }

        public virtual IEnumerable<double> GetRandomDoubleEnumerable(int count, int startRange = -10, int endRange = 10)
        {
            if (count < 1)
            {
                throw new ArgumentException("Count of number can't be less than 1", nameof(count));
            }
            if (startRange > endRange)
            {
                throw new ArgumentOutOfRangeException(nameof(startRange), "Startrange can't be greater than endrange");
            }
            var resArr = new double[count];
            for (var i = 0; i < count; i++)
            {
                resArr[i] = Math.Round(_random.NextDouble() * (startRange - endRange) + endRange, 2);
            }
            return resArr;
        }

        public virtual bool GetNumber(out int number, string message)
        {
            _outputService.ShowMessage(message);
            return int.TryParse(_inputService.GetString(), out number);
        }

        public virtual bool GetNumber(out int number, IEnumerable<string> messages)
        {
            foreach (var message in messages)
            {
                _outputService.ShowMessage(message);
            }
            return int.TryParse(_inputService.GetString(), out number);
        }
    }
}
