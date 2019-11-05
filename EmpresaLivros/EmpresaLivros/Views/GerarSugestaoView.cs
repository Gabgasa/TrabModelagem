using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros.Views
{
    class GerarSugestaoView
    {
        public GerarSugestaoView()
        { 
        }

        public static void gerarSugestao(List<Livro> livros)
        {
            int i = 1;
            Console.WriteLine("Lista de sugestões:\n");
            foreach (Livro lv in livros)
            {
                Console.WriteLine($"\t{i} - {lv.Titulo}");
                i++;
            }
        }

        public static void erroSugestao()
        {
            Console.WriteLine("Não há sugestões disponiveis no momento.\n");
        }
    }
}
