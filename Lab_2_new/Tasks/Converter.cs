using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_new.Tasks
{
    public static class Converter
    {
        public static double GetConvertionResult(double grams, int coef)
        {
            return grams / coef;
        }

        public static double GetConvertionResult(double grams, ConvertCoefEnum coef)
        {
            return grams / (int)coef;
        }
    }
}
