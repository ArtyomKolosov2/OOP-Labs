using System;
using System.IO;
using Lab5.Utils;
using Lab5.Views;
using NSubstitute;
using NUnit.Framework;

namespace Lab5.Tests
{
    [TestFixture]
    public class Lab5ExtractorTest
    {
       
        [TestCase("")]
        [TestCase("3g4er")]
        [TestCase("abc")]
        [TestCase("2147483648")]
        [TestCase("-2147483649")]
        public void GetNumber_ConsoleInputIsInvalid_ReturnsFalse(string str)
        {
            Console.SetIn(new StringReader(str));
            var extractor = Substitute.For<TaskExtractor>(OutputService.GetInstance(), InputService.GetInstance());
            bool actualResult = extractor.GetNumber(out _ ,string.Empty);
            Assert.IsFalse(actualResult);
        }

        [TestCase("0", ExpectedResult = 0)]
        [TestCase("-2147483648", ExpectedResult = -2147483648)]
        [TestCase("2147483647", ExpectedResult = 2147483647)]
        [TestCase("283647", ExpectedResult = 283647)]
        [TestCase("  -2147483648  ", ExpectedResult = -2147483648)]
        public int GetNumber_ConsoleInputIsValid_ReturnsResult(string str)
        {
            Console.SetIn(new StringReader(str));
            var extractor = Substitute.For<TaskExtractor>(OutputService.GetInstance(), InputService.GetInstance());
            bool actualResult = extractor.GetNumber(out var result, string.Empty);
            Assert.IsTrue(actualResult);
            return result;
        }
    }
}
