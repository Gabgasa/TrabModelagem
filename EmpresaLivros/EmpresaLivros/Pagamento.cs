using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Pagamento
    {
        public Pagamento()
        {
        }

        public static void efetuarPagamento(Pedido pedido, Cliente cliente)
        {
            if (cliente.Balanco <= pedido.Valorpedido)
            {
                Console.WriteLine(cliente.Balanco);
                Views.PagamentoView.erroBalancoInsuficiente();
                return;
            }
            else
            {

                cliente.Balanco -= pedido.Valorpedido;
                foreach (ItemPedido ipedido in pedido.ItemsPedidos)
                {
                    cliente.addLivro(ipedido.LivroPedido);
                }
            }
            ClienteDao.saveClientes();
        }
    }
}
