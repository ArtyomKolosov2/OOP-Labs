using Lab5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Utils
{
    public class InputService : IInputService
    {
        private static readonly object _syncRoot = new object();
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
