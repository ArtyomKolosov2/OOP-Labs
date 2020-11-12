using Lab4.Views;
using Lab4.Utils;
using Lab4.Controller;
using System.Collections.Generic;
using Lab4.Model.Tasks.Base;
using Lab4.Model.Tasks.Additional;
using Lab4.Model.Tasks.Common;
using Lab4.Model.Tasks.Individual.IndividualTasksA;
using Lab4.Model.Tasks.Individual.IndividualTasksB;

namespace Lab4
{
    class Program
    {
        private static IInputService _inputService = InputService.GetInstance();
        private static IOutputService _outputService = OutputService.GetInstance();
        private static MainController _mainController;

        public static void Main(string[] args)
        {
            List<ITask> enumerable = new List<ITask>
                {
                    new Common1(),
                    new Common2(),
                    new Common3(),
                    new IndividualA1(),
                    new IndividualA2(),
                    new IndividualA3(),
                    new IndividualA4(),
                    new IndividualA5(),
                    new IndividualB1(),
                    new IndividualB2(),
                    new IndividualB3(),
                    new IndividualB4(),
                    new IndividualB5(),
                    new IndividualB6(),
                    new IndividualB7(),
                    new IndividualB8(),
                    new IndividualB9(),
                    new Additional1(),

                };
            _mainController = new MainController
            (
                enumerable,
                _inputService,
                _outputService
            );
            _mainController.StartController();
        }
    }
}
