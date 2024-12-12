using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TestProgram
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestSortArrayDescending()
        {
            // Arrange
            int arraySize = 10;
            int[] numbers = new int[arraySize];
            Random rand = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = rand.Next(1, 101);
            }

            // Act
            Array.Sort(numbers, (x, y) => y.CompareTo(x));

            // Assert
            for (int i = 0; i < arraySize - 1; i++)
            {
                Assert.IsTrue(numbers[i] >= numbers[i + 1], $"Array is not sorted in descending order at index {i}");
            }
        }
    }
}
