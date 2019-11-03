using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class MenuInicialView
    {
        public void menuInicial()
        {
            Console.WriteLine("Bem vindo ao aplicativo de venda de Livros");
            Console.WriteLine("Escolha uma das seguintes opções");
            Console.WriteLine("\t1 - Publicar um Livro");
            Console.WriteLine("\t2 - Buscar livros baseado em um tema");
            Console.WriteLine("\t3 - Comprar um livro");
            Console.WriteLine("\t4 - Gerar Sugestão.");
            Console.WriteLine("\t5 - Sair");
        }
    }
}
