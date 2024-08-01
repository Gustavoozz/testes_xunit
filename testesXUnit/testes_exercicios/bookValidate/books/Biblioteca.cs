using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books
{
    public class Biblioteca
    {
        public List<Book> Livros { get; set; }

        public Biblioteca()
        {
            Livros = new List<Book>();
        }

        public void AdicionarLivro(Book livro)
        {
            Livros.Add(livro);
        }
    }
}
