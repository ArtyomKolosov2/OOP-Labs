using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_new.Tasks
{
    public static class Task2
    {
        public enum BytesCoef
        {
            KiloBytes = 10,
            MegaBytes = 20,
            GigaBytes = 30,
            TeraBytes = 40
        }
        public static void StartTask()
        {
            IOservice.ShowMessage("Input bytes: ");
            if (long.TryParse(IOservice.GetUserInputStr(), out long bytesAmount))
            {
                IOservice.ShowMessage
                (
                   $"Bytes amount = {bytesAmount}\n" + 
                   $"{GetByteConvertationResult(bytesAmount, BytesCoef.KiloBytes)} kB\n"+
                   $"{GetByteConvertationResult(bytesAmount, BytesCoef.MegaBytes)} mB\n"+
                   $"{GetByteConvertationResult(bytesAmount, BytesCoef.GigaBytes)} gB\n"+
                   $"{GetByteConvertationResult(bytesAmount, BytesCoef.TeraBytes)} tB\n"
                );
            }
            else
            {
                IOservice.ShowMessage("Error!");
            }
        }
        public static double GetByteConvertationResult(long bytesAmount, BytesCoef coef)
        {
            return bytesAmount / Math.Pow(2, (int)coef);
        }
    }
}
