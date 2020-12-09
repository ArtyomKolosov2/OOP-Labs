using Lab5.Interfaces;
using Lab5.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5.Controllers
{
    public class MainController
    {
        public List<ITaskResult> Tasks { get; set; }
        public IInputService InputService { get; init; }
        public IOutputService OutputService { get; init; }
        public TaskExtractor Extractor { get; init; }
        public MainController(List<ITaskResult> tasks, IInputService inputService, IOutputService outputService)
        {
            InputService = inputService;
            OutputService = outputService;
            Tasks = tasks;
            Extractor = new TaskExtractor(outputService, inputService);
        }

        public void StartController()
        {
            while (true)
            {
                ShowTaskMenu();
                OutputService.ShowMessage("0 - Exit");
                if (!Extractor.GetNumber(out int key, "Input number of your task: "))
                {
                    OutputService.ShowMessage("Error: Invalid task number input");
                    continue;
                }
                if (key == 0)
                {
                    break;
                }
                ITaskResult currentTask = GetTaskByIndex(key - 1);
                if (currentTask is not null)
                {
                    string taskResultString;
                    try
                    {
                        taskResultString = currentTask.GetTaskResult(Extractor);
                    }
                    catch (Exception ex)
                    {
                        taskResultString = ex.Message;
                    }
                    OutputService.ShowMessage(taskResultString);
                }
                else
                {
                    OutputService.ShowMessage("Error: Wrong input!");
                }
            }
        }

        private ITaskResult GetTaskByIndex(int index)
        {
            if (index >= 0 && index < Tasks.Count)
            {
                return Tasks[index];
            }
            return null;

        }
        private void ShowTaskMenu()
        {
            var i = 1;
            foreach (var info in Tasks.OfType<ITaskInfo>())
            {
                ShowTaskInfo(info, i++);
            }
        }
        private void ShowTaskInfo(ITaskInfo taskInfo, int index)
        {
            OutputService.ShowMessage($"{index} - {taskInfo.GetInfo()}");
        }
    }
}
