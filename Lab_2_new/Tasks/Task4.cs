using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_new.Tasks
{
    public static class Task4
    {
        public static void StartTask()
        {
            int a = 5, 
                b = 10;
            Console.WriteLine($"a = {a}, b = {b}");
            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
            Console.WriteLine($"Swapped a = {a}, b = {b}");
        }
    }
}
