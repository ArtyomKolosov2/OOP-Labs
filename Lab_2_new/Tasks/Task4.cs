using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_new.Tasks
{
    public static class Task4
    {
        public static void StartTaskOne()
        {
            int a = 5, 
                b = 10;
            IOservice.ShowMessage($"a = {a}, b = {b}");
            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
            IOservice.ShowMessage($"Swapped a = {a}, b = {b}");
            IOservice.ShowMessage($"a = {a}, b = {b}");
            a = a + b; 
            b = a - b;
            a = a - b;
            IOservice.ShowMessage($"Swapped a = {a}, b = {b}");
        }
    }
}
