using System;

namespace Lab4.Views
{
   public class OutputService : IOutputService
   {
        private static readonly object _syncRoot = new object();
        private static OutputService _instance;
        public static OutputService GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new OutputService();
                    }
                }
            }
            return _instance;
        }
        private OutputService()
        {

        }
        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
