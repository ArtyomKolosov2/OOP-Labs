using System;
using System.IO;
using Lab6.Utils;
using Lab6.Views;
using NUnit.Framework;

namespace Lab6.Tests
{
    [TestFixture]
    public class Lab6ExtractorTest
    {
        [Test]
        [TestCase("")]
        [TestCase("3g4er")]
        [TestCase("abc")]
        [TestCase("2147483648")]
        [TestCase("-2147483649")]
        public void GetNumber_ConsoleInputIsInvalid_ReturnsFalse(string str)
        {
            Console.SetIn(new StringReader(str));
            var extractor = new TaskExtractor(OutputService.GetInstance(), InputService.GetInstance());
            bool actualResult = extractor.GetNumber(out _, string.Empty);
            Assert.IsFalse(actualResult);
        }

        [Test]
        [TestCase("0", ExpectedResult = 0)]
        [TestCase("-2147483648", ExpectedResult = -2147483648)]
        [TestCase("2147483647", ExpectedResult = 2147483647)]
        [TestCase("283647", ExpectedResult = 283647)]
        [TestCase("  -2147483648  ", ExpectedResult = -2147483648)]
        public int GetNumber_ConsoleInputIsValid_ReturnsResult(string str)
        {
            Console.SetIn(new StringReader(str));
            var extractor = new TaskExtractor(OutputService.GetInstance(), InputService.GetInstance());
            bool actualResult = extractor.GetNumber(out var result, string.Empty);
            Assert.IsTrue(actualResult);
            return result;
        }

        [Test]
        [TestCase(-435, -645)]
        [TestCase(100, 10)]
        [TestCase(int.MaxValue, int.MinValue)]
        public void Extractor_RangeIsInvalid_ThrowsArgumentOutOfRangeException(int start, int end)
        {
            var extractor = new TaskExtractor(OutputService.GetInstance(), InputService.GetInstance());
            const int ARRAY_SIZE = 40;
            Assert.Throws<ArgumentOutOfRangeException>(() => extractor.GetRandomDoubleEnumerable(count:ARRAY_SIZE, startRange:start, endRange:end));
        }

        [Test]
        [TestCase(-435)]
        [TestCase(0)]
        [TestCase(int.MinValue)]
        public void Extractor_CountIsInvalid_ThrowsArgumentException(int count)
        {
            var extractor = new TaskExtractor(OutputService.GetInstance(), InputService.GetInstance());
            Assert.Throws<ArgumentException>(() => extractor.GetRandomDoubleEnumerable(count));
        }
    }
}
