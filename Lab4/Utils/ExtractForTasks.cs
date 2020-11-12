using Lab4.Utils.MyConverter;
using Lab4.Views;
using System;

namespace Lab4.Utils
{
    class ExtractForTasks
    {
        private readonly Random rand = new Random();

        protected IInputService _inputService { get; set; }
        protected IOutputService _outputService { get; set; }

        public ExtractForTasks(IInputService inputService, IOutputService outputService)
        {
            _inputService = inputService;
            _outputService = outputService;
        }

        public int Common1()
        {
            _outputService.ShowMessage("Input count of years: ");
            return Converter.ConvertToInt(_inputService.GetString());
        }
        public int[] Common2()
        {
            _outputService.ShowMessage("Fill in the array of numbers:");
            return Converter.ConvertToArrayInt(_inputService.GetString());;
        }
        public int Common3()
        {
            _outputService.ShowMessage("Input number: ");
            return Converter.ConvertToInt(_inputService.GetString());
        }
        public double[] IndividualA1()
        {
            _outputService.ShowMessage("Input 3 sides: ");
            double a = Converter.ConvertToDouble(_inputService.GetString());
            double b = Converter.ConvertToDouble(_inputService.GetString());
            double c = Converter.ConvertToDouble(_inputService.GetString());
            double[] arrSides = { a, b, c };
            return arrSides;
        }
        // Error
        public string IndividualA2()
        {
            _outputService.ShowMessage("Input letter: ");
            return _inputService.GetString();
        }
        public int IndividualA3()
        {
            _outputService.ShowMessage("The mood of the user:");
            const int MaxValue = 100;
            return rand.Next(MaxValue);
        }
        public int[] IndividualA4()
        {
            _outputService.ShowMessage("Roll the dice:");
            const int CountPoint = 6;
            int firstDie = rand.Next(CountPoint);
            int secondDie = rand.Next(CountPoint);
            int[] arrDies = { firstDie, secondDie };
            return arrDies;
        }
        public int IndividualA5()
        {
            _outputService.ShowMessage("Open pie with a surprise...");
            int countSurprise = 8;
            return rand.Next(countSurprise);
        }
        public int IndividualB1()
        {
            _outputService.ShowMessage("Input number from 1 to 7:");
            return Converter.ConvertToInt(_inputService.GetString());
        }
        public int IndividualB2()
        {
            _outputService.ShowMessage("Input number from 0 to 10:");
            return Converter.ConvertToInt(_inputService.GetString());
        }
        public int[] IndividualB3()
        {
            _outputService.ShowMessage("A card and suit are generated...");
            int indexAdvantage = rand.Next(4);
            int indexSuits = rand.Next(8);
            int[] resArr = { indexAdvantage, indexSuits };
            return resArr;
        }
        public int IndividualB4()
        {
            _outputService.ShowMessage("Age generated...");
            int countNumbers = 120;
            return rand.Next(countNumbers);
        }
        public uint[] IndividualB5()
        {
            _outputService.ShowMessage("Input number mounth:");
            uint numberMounth = Converter.ConvertToUInt(_inputService.GetString());
            _outputService.ShowMessage("Input number year:");
            uint numberYear = Converter.ConvertToUInt(_inputService.GetString());
            uint[] arrDate = { numberMounth, numberYear };
            return arrDate;
        }
        public int IndividualB6()
        {
            _outputService.ShowMessage("Input number mounth:");
            return Converter.ConvertToInt(_inputService.GetString());
        }
        public int[] IndividualB7()
        {
            _outputService.ShowMessage("Input operation and two numbers:");
            string operation = _inputService.GetString();
            int number1 = Converter.ConvertToInt(_inputService.GetString());
            int number2 = Converter.ConvertToInt(_inputService.GetString());
            int[] arrDate = { operation[0], number1, number2 };
            return arrDate;
        }
        public int[] IndividualB8()
        {
            _outputService.ShowMessage("Input number day:");
            int day = Converter.ConvertToInt(_inputService.GetString());
            _outputService.ShowMessage("Input number mounth:");
            int mounth = Converter.ConvertToInt(_inputService.GetString());
            int[] arrData = { day, mounth };
            return arrData;
        }
        public int IndividualB9()
        {
            _outputService.ShowMessage("Input number:");
            return Converter.ConvertToInt(_inputService.GetString());
        }
        public int[] Additional1()
        {
            _outputService.ShowMessage("Input day:");
            int day = Converter.ConvertToInt(_inputService.GetString());
            _outputService.ShowMessage("Input mounth:");
            int mounth = Converter.ConvertToInt(_inputService.GetString());
            _outputService.ShowMessage("Input year:");
            int year = Converter.ConvertToInt(_inputService.GetString());
            int[] arrSides = { day, mounth, year };
            return arrSides;
        }
    }
}
