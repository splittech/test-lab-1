using System.Collections.Generic;
using Game;
using NUnit.Framework;

namespace Tests
{
    public class CalculatorTests
    {
        [Test]
        public void FindSumBetweenFirstAndLastNegativeElement_EmptyList()
        {
            // Arrange.
            Calculator calculator = new();
            List<int> numbers = new() { };
            int expectedResult = -1;

            // Act.
            int actualResult = calculator.FindSumBetweenFirstAndLastNegativeElement(numbers);

            // Assert.
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void FindSumBetweenFirstAndLastNegativeElement_NegativeNumberFoundImmediately()
        {
            // Arrange.
            Calculator calculator = new();
            List<int> numbers = new() { -1 };
            int expectedResult = 0;

            // Act.
            int actualResult = calculator.FindSumBetweenFirstAndLastNegativeElement(numbers);

            // Assert.
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void FindSumBetweenFirstAndLastNegativeElement_NoNegativeElements()
        {
            // Arrange.
            Calculator calculator = new();
            List<int> numbers = new() { 1 };
            int expectedResult = -1;

            // Act.
            int actualResult = calculator.FindSumBetweenFirstAndLastNegativeElement(numbers);

            // Assert.
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void FindSumBetweenFirstAndLastNegativeElement_SecondLoopSkipsNonNegativeNumber()
        {
            // Arrange.
            Calculator calculator = new();
            List<int> numbers = new() { -1, 1 };
            int expectedResult = 0;

            // Act.
            int actualResult = calculator.FindSumBetweenFirstAndLastNegativeElement(numbers);

            // Assert.
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void FindSumBetweenFirstAndLastNegativeElement_SumElementsBetweenNegative()
        {
            // Arrange.
            Calculator calculator = new();
            List<int> numbers = new() { -1, 1, 1, -1 };
            int expectedResult = 2;

            // Act.
            int actualResult = calculator.FindSumBetweenFirstAndLastNegativeElement(numbers);

            // Assert.
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
