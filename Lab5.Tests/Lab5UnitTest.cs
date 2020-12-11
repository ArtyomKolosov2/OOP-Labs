using Lab5.Models.Task_A;
using Lab5.Models.Task_B;
using Lab5.Models.Task_C;
using Lab5.Models.Task_D;
using Lab5.Models.Task_E;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Lab5.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        [TestCase(123,6)]
        [TestCase(1243546, 25)]
        [TestCase(-555, 15)]
        [TestCase(-123, 6)]
        [TestCase(444444, 24)]
        [TestCase(int.MaxValue, 46)]
        [TestCase(0, 0)]
        public void TestTaskA2(int number, int expected)
        {
            Assert.AreEqual(expected, TaskA2.GetSumOfNumbers(number));
        }
        [Test]
        [TestCase(222, 3)]
        [TestCase(-222, 3)]
        [TestCase(123, 1)]
        [TestCase(123425365, 4)]
        [TestCase(int.MaxValue, 6)]
        public void TestTaskA5(int number, int expected)
        {
            Assert.AreEqual(expected, TaskA5.GetAmountOfEvenNumber(number));
        }

        [Test]
        [TestCase(123, false)]
        [TestCase(222, true)]
        [TestCase(111, false)]
        [TestCase(-111, false)]
        [TestCase(-246886420, true)]
        public void TestTaskB1(int number, bool expected)
        {
            Assert.AreEqual(expected, TaskB1.IsOnlyEvenInNums(number));
        }

        [Test]
        [TestCase(123, false)]
        [TestCase(222, true)]
        [TestCase(111, false)]
        [TestCase(-122, true)]
        [TestCase(-246886420, true)]
        [TestCase(int.MaxValue, true)]
        public void TestTaskB5(int number, bool expected)
        {
            Assert.AreEqual(expected, TaskB5.IsEvenNumsPrevail(number));
        }

        [Test]
        [TestCase(123, true)]
        [TestCase(321, true)]
        [TestCase(987654321, true)]
        [TestCase(-654321, true)]
        [TestCase(-655321, false)]
        [TestCase(-246886420, false)]
        [TestCase(int.MaxValue, false)]
        public void TestTaskC1(int number, bool expected)
        {
            Assert.AreEqual(expected, TaskC1.IsContainSequence(number));
        }
        [Test]
        [TestCase(123, false)]
        [TestCase(124356445, false)]
        [TestCase(1342323, false)]
        [TestCase(-12323, false)]
        [TestCase(-1221, true)]
        [TestCase(7777, true)]
        [TestCase(777, true)]
        [TestCase(-5665, true)]
        public void TestTaskC2(int number, bool expected)
        {
            Assert.AreEqual(expected, TaskC2.IsPalindrome(number));
        }

        [Test]
        [TestCase(356897, 6)]
        [TestCase(555555, 1)]
        [TestCase(-555555, 1)]
        [TestCase(-43550, 4)]
        [TestCase(40000, 2)]
        [TestCase(int.MaxValue, 7)]
        [TestCase(0, 1)]
        public void TestTaskD1(int number, int expected)
        {
            Assert.AreEqual(expected, TaskD1.FindOriginalNumberCount(number));
        }

        [Test]
        [TestCase(34254689, 9)]
        [TestCase(-23434, 4)]
        [TestCase(73434, 7)]
        [TestCase(9869, 9)]
        [TestCase(0, 0)]
        [TestCase(int.MaxValue, 8)]
        public void TestTaskD2(int number, int expected)
        {
            Assert.AreEqual(expected, TaskD2.FindMaxNumber(number));
        }

        [TestCase(34, 3524578)]
        [TestCase(9, 21)]
        [TestCase(1, 0)]
        [TestCase(10, 34)]
        [TestCase(13, 144)]
        public void TestTaskE1_PositionIsValid(int number, int expected)
        {
            Assert.AreEqual(expected, TaskE1.FindFibonachi(number));
        }

        [TestCase(5, ExpectedResult = new int[] { 0,1,1,2,3 })]
        [TestCase(10, ExpectedResult = new int[] { 0,1,1,2,3,5,8,13,21,34 })]
        [TestCase(15, ExpectedResult = new int[] { 0,1,1,2,3,5,8,13,21,34,55,89,144,233,377 })]
        public IEnumerable<int> TestTaskE2_PositionIsValid(int number)
        {
            return TaskE2.FindFibonachiSequence(number);
        }

        [Test]
        [TestCase(-43435)]
        [TestCase(-456)]
        [TestCase(int.MinValue)]
        public void TaskE1_PositionIsInvalid_ThrowsArgumentException(int position)
        {
            Assert.Throws<ArgumentException>(() => TaskE1.FindFibonachi(position));
        }
        [Test]
        [TestCase(-435)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void TaskE2_PositionIsInvalid_ThrowsArgumentException(int position)
        {
            Assert.Throws<ArgumentException>(() => TaskE2.FindFibonachiSequence(position));
        }
    }
}