
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Unit.Tests
{
    [Collection("Calculator Unit Tests Collection")]
    public class AdditionTests
    {
        private readonly CalculatorUnittestsFixture _calculatorFixture;

        public AdditionTests(CalculatorUnittestsFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(-3, -4, -7)]
        [InlineData(3, -4, -1)]
        public void Add_AddingTwoNumbers_ReturnsCorrectSum(int firstNumber, int secondNumber, int expectedResult)
        {
            // Arrange
            var calculator = _calculatorFixture.Calculator;

            // Act
            var result = calculator.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
