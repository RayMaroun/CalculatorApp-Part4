using CalculatorApp.Integration.Tests.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Integration.Tests
{
    public class CalculatorIntegrationTests : IClassFixture<CalculatorIntegrationTestsFixture>
    {

        private readonly CalculatorIntegrationTestsFixture _calculatorFixture;

        public CalculatorIntegrationTests(CalculatorIntegrationTestsFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Theory]
        [InlineData(2, 3, 5, 5, 2, 3)]
        public void AdditionAndSubtraction_ShouldReturnCorrectResult_WhenNumbersAreProvided(int a, int b, int expectedAddition, int c, int d, int expectedSubtraction)
        {
            // Arrange
            var calculator = _calculatorFixture.Calculator;

            // Act
            var result1 = calculator.Add(a, b);
            var result2 = calculator.Subtract(c, d);

            // Assert
            Assert.Equal(expectedAddition, result1);
            Assert.Equal(expectedSubtraction, result2);
        }

        [Theory]
        [InlineData(2, 3, 5, 5, 2, 3, 15)]
        public void MultipleOperations_ShouldProduceExpectedResult_WhenValidInputsAreGiven(int a, int b, int expectedAddition, int c, int d, int expectedSubtraction, int expectedMultiplication)
        {
            // Arrange
            var calculator = _calculatorFixture.Calculator;

            // Act
            var result1 = calculator.Add(a, b);
            var result2 = calculator.Subtract(c, d);
            var result3 = calculator.Multiply(result1, result2);

            // Assert
            Assert.Equal(expectedAddition, result1);
            Assert.Equal(expectedSubtraction, result2);
            Assert.Equal(expectedMultiplication, result3);
        }

        [Theory]
        [InlineData(2, 3, 5, 5, 2, 3, 15, 2, 7.5)]
        [InlineData(2, 3, 5, 5, 2, 3, 15, 0, double.PositiveInfinity)]
        public void PerformComplexMathematicalOperations_CorrectlyAppliesMultipleOperations_ExpectedResults(int a, int b, int expectedAddition, int c, int d, int expectedSubtraction, int expectedMultiplication, int e, double expectedDivision)
        {
            // Arrange
            var calculator = _calculatorFixture.Calculator;

            // Act
            var result1 = calculator.Add(a, b);
            var result2 = calculator.Subtract(c, d);
            var result3 = calculator.Multiply(result1, result2);
            

            // Assert
            Assert.Equal(expectedAddition, result1);
            Assert.Equal(expectedSubtraction, result2);
            Assert.Equal(expectedMultiplication, result3);
            if (e == 0)
            {
                Assert.Throws<DivideByZeroException>(() => calculator.Divide(result3, e));
            }
            else
            {
                var result4 = calculator.Divide(result3, e);
                Assert.Equal(expectedDivision, result4);
            }
        }
    }
}
