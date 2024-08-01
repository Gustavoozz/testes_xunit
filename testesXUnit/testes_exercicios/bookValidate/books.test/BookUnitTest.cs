using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace books.test
{
    public class BookUnitTest
    {
        [Fact]
        public void AddCorrectName()
        {
            // Arrange
            var biblioteca = new Biblioteca();
            var expectedName = "Diario de um Banana II";
            var livro = new Book(expectedName);

            // Act
            biblioteca.AdicionarLivro(livro);
            var bookOnList = biblioteca.Livros[0];

            // Assert
            Assert.NotNull(bookOnList);
            Assert.Equal(expectedName, bookOnList.Nome);
        }
    }
}
