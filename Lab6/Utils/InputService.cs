using Lab6.Interfaces;
using System;

namespace Lab6.Utils
{
    public class InputService : IInputService
    {
        private static readonly object _syncRoot = new ();
        private static InputService _instance;
        public static InputService GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new InputService();
                    }
                }
            }
            return _instance;
        }
        private InputService()
        {

        }
        public string GetString()
        {
            return Console.ReadLine();
        }
    }
}
