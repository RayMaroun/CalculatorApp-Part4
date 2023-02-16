
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Unit.Tests
{
    [Collection("Calculator Unit Tests Collection")]
    public class MultiplicationTests
    {
        private readonly CalculatorUnittestsFixture _calculatorFixture;

        public MultiplicationTests(CalculatorUnittestsFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Theory]
        [InlineData(3, 4, 12)]
        [InlineData(-3, 4, -12)]
        [InlineData(3, -4, -12)]
        public void Multiply_MultiplyingTwoNumbers_ReturnsCorrectProduct(int firstNumber, int secondNumber, int expectedResult)
        {
            // Arrange
            var calculator = _calculatorFixture.Calculator;

            // Act
            var result = calculator.Multiply(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
