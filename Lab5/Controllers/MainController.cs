using Lab4.Model.Tasks.Base;
using Lab5.Interfaces;
using Lab5.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Controllers
{
    public class MainController
    {
        public List<ITaskResult> Tasks { get; set; }
        public IInputService Input { get; init; }
        public IOutputService Output { get; init; }

        public TaskExtractor Extractor { get; init; }
        public MainController(List<ITaskResult> tasks, IInputService inputService, IOutputService outputService)
        {
            Input = inputService;
            Output = outputService;
            Tasks = tasks;
            Extractor = new TaskExtractor(outputService, inputService);
        }

        public void StartController()
        {
            while (true)
            {
                ShowTaskMenu();
                Output.ShowMessage("0 - Exit");
                Output.ShowMessage("Input number of your task:");
                int key = Convert.ToInt32(Input.GetString());
                if (key == 0)
                {
                    break;
                }
                ITaskResult currentTask = GetTaskByIndex(key - 1);
                if (currentTask != null)
                {
                    string taskResultString = string.Empty;
                    try
                    {
                        taskResultString = currentTask.GetTaskResult(Extractor);
                    }
                    catch (Exception ex)
                    {
                        taskResultString = ex.Message;
                    }
                    Output.ShowMessage(taskResultString);
                }
                else
                {
                    Output.ShowMessage("Error: Wrong input!");
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
            foreach (var info in Tasks)
            {
                ShowTaskInfo((ITaskInfo)info, i++);
            }
        }
        private void ShowTaskInfo(ITaskInfo taskInfo, int index)
        {
            Output.ShowMessage($"{index}. {taskInfo.GetInfo()}");
        }
    }
}
