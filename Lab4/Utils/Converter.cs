using System;

namespace Lab4.Utils.MyConverter
{
    public class Converter
    {
        public static int[] ConvertToArrayInt(string value)
        {
            int[] res = Array.ConvertAll(value.Split(), int.Parse);
            return res;
        }
        public static int ConvertToChar(char letter)
        {
            return letter;
        }
        public static char ConvertToChar(int letter)
        {
            return (char)letter;
        }
        public static int ConvertToInt(string value)
        {
            int.TryParse(value, out int res);
            return res;
        }
        public static uint ConvertToUInt(string value)
        {
            uint.TryParse(value, out uint res);
            return res;
        }
        public static double ConvertToDouble(string value)
        {
            double.TryParse(value, out double res);
            return res;
        }
    }
}
