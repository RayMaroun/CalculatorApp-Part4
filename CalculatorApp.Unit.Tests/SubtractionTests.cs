
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Unit.Tests
{
    [Collection("Calculator Unit Tests Collection")]
    public class SubtractionTests
    {
        private readonly CalculatorUnittestsFixture _calculatorFixture;

        public SubtractionTests(CalculatorUnittestsFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Theory]
        [InlineData(3, 4, -1)]
        [InlineData(-3, -4, 1)]
        [InlineData(3, -4, 7)]
        public void Subtract_SubtractingTwoNumbers_ReturnsCorrectDifference(int firstNumber, int secondNumber, int expectedResult)
        {
            // Arrange
            var calculator = _calculatorFixture.Calculator;

            // Act
            var result = calculator.Subtract(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
