using System.Collections.Generic;
using Game;
using NUnit.Framework;

namespace Tests
{
    public class CalculatorTests
    {
        [Test]
        public void FindSumBetweenFirstAndLastNegativeElement_Normal()
        {
            // Arrange.
            Calculator calculator = new();
            List<int> numbers = new() { -1, 1, 1, 1, -1 };
            int expectedResult = 3;

            // Act.
            int actualResult = calculator.FindSumBetweenFirstAndLastNegativeElement(numbers);

            // Assert.
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
