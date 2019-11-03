using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros.Views
{
    class ListarLivrosTemaView
    {
        public ListarLivrosTemaView()
        {
        }

        public void listarLivrosInicio()
        {
            Console.WriteLine("Por favor digite o nome do tema que você deseja procurar.\n");

        }

        public void listarLivrosErro(string tema)
        {
            Console.WriteLine($"Tema {tema} não encontrado, favor digitar novamente.\n");
        }

        public void listarLivrosSucesso(string tema)
        {
            Console.WriteLine($"Tema {tema} encontrado, segue a lista abaixo.\n");
        }

        public void mostraLivro(string livro)
        {
            Console.WriteLine(livro);
        }

        public void listaTodosLivros()
        {
            Console.WriteLine("Listando todos os livros.\n");
        }
    }
}
