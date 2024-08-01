using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace calculos.test
{
    public class CalculoUnitTest
    {
        // Principio AAA: Act, Arrange and Assert.
        // Principio AAA: Agir, Organizar e Provar. 
        [Fact]
        public void AddTwoNumbers()
        {
            // Arrange ( Organizar ).
            var n1 = ;
            var n2 = 2.2;
            var expectedValue = 5.5;

            // Act ( Agir ).
            var add = Calculo.Add(n1, n2);

            // Assert ( Provar ).
            Assert.Equal(expectedValue, add);

        }

        [Fact]
        public void MinusTwoNumbers()
        {
            var n1 = 3.1;
            var n2 = 2.1;
            var expectedValue = 1;

            var minus = Calculo.Minus(n1, n2);

            Assert.Equal(expectedValue, minus);
        }

        [Fact]
        public void MultiplicateTwoNumbers()
        {
            var n1 = 3.3;
            var n2 = 2.2;
            var expectedValue = 7.26;

            var multiplication = Calculo.Multiplication(n1, n2);

            Assert.Equal(expectedValue, multiplication);
        }

        [Fact]
        public void DivideTwoNumbers()
        {
            var n1 = 3.5;
            var n2 = 3.5;
            var expectedValue = 1;

            var divide = Calculo.Divide(n1, n2);

            Assert.Equal(expectedValue, divide);
        }

        [Fact]
        public void ModuleOfTwoNumbers()
        {
            var n1 = 5;
            var n2 = 2;
            var expectedValue = 1;

            var module = Calculo.Module(n1, n2);

            Assert.Equal(expectedValue, module);
        }
    }
}
