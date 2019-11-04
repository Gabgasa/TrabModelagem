using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros.Views
{
    class PagamentoView
    {
        public PagamentoView()
        {
        }

        public static void listaDeLivros()
        {
            Console.WriteLine("Lista de livros disponiveis.\n");
        }

        public static void erroBalancoInsuficiente()
        {
            Console.WriteLine("Você não possui fundos suficientes para realizar a compra.\n");
        }

        public static void sucessoPedidoEfetuado()
        {
            Console.WriteLine("Os livros foram comprados e adicionados com sucesso.\n");
        }

        public static void inicioPedidoLivros()
        {
            Console.WriteLine("Digite o nome de um dos livros da lista para coloca-lo no carrinho.\n");
        }

        public static void livroJaComprado()
        {
            Console.WriteLine("Você já possui esse livro.\n");
        }

        public static void listarCarrinhoDeCompras(Pedido pedido)
        {
            int i = 1;
            Console.WriteLine("Carrinho de compras.\n");
            foreach(ItemPedido ipedido in pedido.ItemsPedidos)
            {
                Console.WriteLine($"{i} - {ipedido.LivroPedido.Titulo}");
            }
            Console.WriteLine($"Valor total: {pedido.Valorpedido}");
        }

        public static void continuarCompra()
        {
            Console.WriteLine("\t1 Adicionar outro livro.");
            Console.WriteLine("\t2 Remover um livro.");
            Console.WriteLine("\t3 Finalizar pagamento.");

        }

        public static void adicionarLivro()
        {
            Console.WriteLine("Digite o nome do livro que você quer adicionar.\n");
        }

        public static void removerLivro()
        {
            Console.WriteLine("Digite o nome do livro que você quer remover.\n");
        }
    }
}
