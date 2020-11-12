using Lab4.Model.Tasks.Base;
using Lab4.Views;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Lab4.Utils.MyConverter;

namespace Lab4.Controller
{
    sealed class MainController
    {
        public List<ITask> Tasks { get; }
        public IInputService Input { get; }
        public IOutputService Output { get; }

        public MainController(List<ITask> tasks, IInputService inputService, IOutputService outputService)
        {
            Tasks = tasks;
            Input = inputService;
            Output = outputService;
        }

        public void StartController()
        {  
            while (true)
            {
                ShowTaskMenu();
                Output.ShowMessage("0 - Exit");
                Output.ShowMessage("Input number of your task:");
                int key = Converter.ConvertToInt(Input.GetString());
                if (key == 0)
                {
                    break;
                }
                ITask currentRunTask = GetTaskByIndex(key-1);
                if (currentRunTask != null)
                {
                    string taskResultString = string.Empty;
                    try
                    {
                        taskResultString = currentRunTask.Run();
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

        private ITask GetTaskByIndex(int index)
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