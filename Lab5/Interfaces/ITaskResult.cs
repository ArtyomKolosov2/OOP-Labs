using Lab5.Utils;
using System.Collections.Generic;

namespace Lab4.Model.Tasks.Base
{
    public interface ITaskResult
    {
       public string GetTaskResult(TaskExtractor extractor);
    }
}