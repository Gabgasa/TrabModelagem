using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class ControladorPagamento
    {
        Pedido pedido = new Pedido(0);
        public ControladorPagamento()
        {
        }

        public void Pagamento(Cliente cliente)
        {
            ControladorListarLivrosTema livrosTema = new ControladorListarLivrosTema();
            livrosTema.ListarLivros();
            Views.PagamentoView.inicioPedidoLivros();
            adicionarCarrinho(cliente);
        }

        private void adicionarCarrinho(Cliente cliente)
        {
            
            string livro = Console.ReadLine();
            if (Livro.existeLivro(livro))
            {
                Livro livroComprado = Livro.procuraLivro(livro);
                if (cliente.verificaLivro(livroComprado))
                {
                    ItemPedido itempedido = new ItemPedido(livroComprado.Valor, livroComprado);
                    pedido.addItemPedido(itempedido);
                    Views.PagamentoView.listarCarrinhoDeCompras(pedido);
                    Views.PagamentoView.continuarCompra();
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Pagamento(cliente);
                            break;
                        case "2":
                            removerLivro(cliente, pedido);
                            break;
                        case "3":
                            efetuarPagamento(cliente, pedido);
                            break;
                    }


                }
                else
                {

                }
            }
        }

        private void removerLivro(Cliente cliente, Pedido pedido)
        {
            Views.PagamentoView.removerLivro();
            string itempedido = Console.ReadLine();
            ItemPedido ipedido = pedido.findItemPedido(itempedido);
            pedido.removeItemPedido(ipedido);
            Views.PagamentoView.listarCarrinhoDeCompras(pedido);
            Pagamento(cliente);
        }

        private void efetuarPagamento(Cliente cliente, Pedido pedido)
        {

        }


    }
}
