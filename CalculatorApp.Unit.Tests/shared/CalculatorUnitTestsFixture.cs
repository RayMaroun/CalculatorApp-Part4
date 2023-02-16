using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Unit.Tests
{
    public class CalculatorUnittestsFixture : IDisposable
    {
        public Calculator Calculator { get; private set; }

        public CalculatorUnittestsFixture()
        {
            Calculator = new Calculator();
        }

        public void Dispose()
        {
        }
    }
}
