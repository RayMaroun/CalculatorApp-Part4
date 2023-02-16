using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Integration.Tests.shared
{
    public class CalculatorIntegrationTestsFixture : IDisposable
    {
        public Calculator Calculator { get; private set; }

        public CalculatorIntegrationTestsFixture()
        {
            Calculator = new Calculator();
        }

        public void Dispose()
        {
        }
    }
}
