using System;

namespace Lab_2_new.Tasks
{
    public static class Task3
    {
        public static void StartTask()
        {
            IOservice.ShowMessage("Input cantimetres: ");
            if (long.TryParse(IOservice.GetUserInputStr(), out long SM))
            {
                IOservice.ShowMessage
                (
                   $"Metres {Converter.GetConvertionResult(SM, (int)ConvertCoefEnum.inMetr)} to {SM} cm\n" +
                   $"Kilometres {Converter.GetConvertionResult(SM, (int)ConvertCoefEnum.inKilometr)} to {SM} сm\n" 
                );
            }
            else
            {
                IOservice.ShowMessage("Error!");
            }
        }
        
    }
}
