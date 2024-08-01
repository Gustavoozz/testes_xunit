using celsiusToFahrenheit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CelsiusToFahrenheit.test
{
    public class CelsiusConvertUnitTest
    {
        [Fact]

        public void Verify()
        {
            // Arrange ( Organizar ).
            var g = 10.6;
            var expectedValue = 51.08;

            // Act ( Agir ).
            var calculate = CelsiusConvert.Calculate(g);

            // Assert ( Provar ).
            Assert.Equal(expectedValue, calculate);
        }
    }
}
