using emails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace email.test
{
    public class EmailUnitTest
    {
        // Possibilidades:
        [Theory]
        [InlineData("exemplo@dominio.com", true)]
        [InlineData("exemplo@dominio", false)]
        [InlineData("exemplo@dominio.c", false)]
        [InlineData("exemplo@.com", false)]
        [InlineData("exemplo@..com", false)]
        [InlineData("exemplo@dominio.com.br", true)]
        [InlineData("exemplo@.br", false)]
        public void IsValid(string email, bool expectedIsValid)
        {
            // Act
            bool actualIsValid = EmailValidator.IsValidEmail(email);

            // Assert
            Assert.Equal(expectedIsValid, actualIsValid);
        }
    }
}
