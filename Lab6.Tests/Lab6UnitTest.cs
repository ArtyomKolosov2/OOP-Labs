using NUnit.Framework;
using Lab6.Models.Individual;
using System;

namespace Lab6.Tests
{
    public class Tests
    {
        [Test]
        [TestCase(new double[] {1, 2, 3, 4 }, 6)]
        [TestCase(new double[] {25, 25, 25 }, 15625)]
        [TestCase(new double[] {1, 100, 4, 250 }, 400)]
        [TestCase(new double[] {-4, 3.3, 4.3, 3.1, 3.567, 25 }, 156.908763)]
        [TestCase(new double[] {25, 3.2, 4.44, 5.42, 3, -4 }, 231.02208)]
        [TestCase(new double[] {int.MinValue, 1, 1, 1, 1, int.MaxValue }, 1)]
        [TestCase(new double[] {int.MaxValue, 2, 2, 2, 2, int.MinValue }, 16)]
        [TestCase(new double[] {0}, 0)]
        [TestCase(new double[] {2,2,2}, 8)]
        public void TaskIndividual1FindMultiply_DataIsValid(double [] array, double expected)
        {
            Assert.AreEqual(expected, TaskIndividual1.FindMultiplyOfElementsBetweenMaxAndMin(array), 0.00002);
        }

        [Test]
        [TestCase(new double[] { 1, 2, -5, -4 }, -9)]
        [TestCase(new double[] { -25, 25, 25 }, -25)]
        [TestCase(new double[] { int.MinValue, 1, 1, 1, 1, int.MaxValue }, -2147483648)]
        [TestCase(new double[] { int.MaxValue, -2.1, -2.22, -2, -2, 0 }, -8.32)]
        [TestCase(new double[] { 0 }, 0)]
        [TestCase(new double[] { -2, -2.5, -2 }, -6.5)]
        [TestCase(new double[] { 2, 2, 2 },  0)]
        public void TaskIndividual1FindSumOfNegaive_DataIsValid(double[] array, double expected)
        {
            Assert.AreEqual(expected, TaskIndividual1.FindSumNegativeElements(array), 0.00002);
        }

        [Test]
        [TestCase(new double[] {0.5, -4, -5, 3, -5, -5, -5 }, -8.5)]
        [TestCase(new double[] {0.5, 105, -5, 5 }, 100.5)]
        [TestCase(new double[] {0, -4, -5, -3, -5, -5, -5 }, 0)]
        [TestCase(new double[] {-1, -1, -1, -1, -1, -1, -1 }, 0)]
        [TestCase(new double[] {1, 1, 2, 3, 4, 5, 6 }, 16)]
        public void TaskIndividual2FindSumOfElements_DataIsValid(double[] array, double expected)
        {
            Assert.AreEqual(expected, TaskIndividual2.SumElementsBeforeLastPositive(array), 0.00002);
        }

        [Test]
        [TestCase(null)]
        public void TaskIndividual1FindMultiply_ArrayIsNull(double [] array)
        {
            Assert.Throws<ArgumentNullException>(() => TaskIndividual1.FindMultiplyOfElementsBetweenMaxAndMin(array));
        }

        [Test]
        [TestCase(new double[] { })]
        public void TaskIndividual1FindMultiply_ArrayIsEmpty(double[] array)
        {
            Assert.Throws<ArgumentException>(() => TaskIndividual1.FindMultiplyOfElementsBetweenMaxAndMin(array));
        }

        [Test]
        [TestCase(null)]
        public void TaskIndividual1FindSumOfNegaive_ArrayIsNull(double[] array)
        {
            Assert.Throws<ArgumentNullException>(() => TaskIndividual1.FindSumNegativeElements(array));
        }

        [Test]
        [TestCase(new double[] { })]
        public void TaskIndividual1FindSumOfNegaive_ArrayIsEmpty(double[] array)
        {
            Assert.Throws<ArgumentException>(() => TaskIndividual1.FindSumNegativeElements(array));
        }

        [Test]
        [TestCase(null)]
        public void TTaskIndividual2FindSumOfElements_ArrayIsNull(double[] array)
        {
            Assert.Throws<ArgumentNullException>(() => TaskIndividual2.SumElementsBeforeLastPositive(array));
        }

        [Test]
        [TestCase(new double[] { })]
        public void TTaskIndividual2FindSumOfElements_ArrayIsEmpty(double[] array)
        {
            Assert.Throws<ArgumentException>(() => TaskIndividual1.FindMultiplyOfElementsBetweenMaxAndMin(array));
        }
    }
}