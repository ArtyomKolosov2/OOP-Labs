﻿using Lab4.Model.Tasks.Base;
using Lab5.Controllers;
using Lab5.Interfaces;
using Lab5.Models.Task_A;
using Lab5.Utils;
using Lab5.Views;
using System;
using System.Collections.Generic;

namespace Lab5
{
    public static class Program
    {
        private static IInputService _inputService = InputService.GetInstance();
        private static IOutputService _outputService = OutputService.GetInstance();
        private static MainController _mainController;

        public static void Main(string[] args)
        {
            List<ITaskResult> tasks = new ()
            {
                new TaskA5()
            };
            _mainController = new MainController
            (
                tasks,
                _inputService,
                _outputService
            );
            _mainController.StartController();
        }
    }
}