using EmpresaLivros.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{ 
    class ControladorListarLivrosTema
    {
        ListarLivrosTemaView Interface = new ListarLivrosTemaView();
        public ControladorListarLivrosTema()
        {    

        }

        public void ListarLivros()
        {
            Interface.listarLivrosInicio();
            string tema = Console.ReadLine();
            buscarLivros(tema);
        }

        public void buscarLivros(string tema)
        {
            List<Livro> livros = new List<Livro>();
            livros = Livro.procuraLivrosTema(livros, tema);

                
            foreach (Livro lv in livros)
            {
                Interface.mostraLivro(lv.Titulo);
            }
            Controlador.Inicio();
            
        }

    }
}
