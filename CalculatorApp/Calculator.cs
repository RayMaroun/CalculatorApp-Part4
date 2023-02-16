using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)numerator / denominator;
        }
    }
}
