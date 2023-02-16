using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Unit.Tests
{
    [CollectionDefinition("Calculator Unit Tests Collection")]
    public class CalculatorUnitTestsCollection : ICollectionFixture<CalculatorUnittestsFixture> { }
}
