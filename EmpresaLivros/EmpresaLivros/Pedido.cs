using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Pedido
    {
        private int codpedido;
        private float valorpedido;
        private List<ItemPedido> itemsPedidos = new List<ItemPedido>();

        public Pedido(float valorpedido)
        {
            Valorpedido = valorpedido;
        }

        public void addItemPedido(ItemPedido ipedido)
        {
            foreach (ItemPedido pd in ItemsPedidos)
            {
                if (pd.LivroPedido.Titulo.Equals(ipedido.LivroPedido.Titulo, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Este item já está no carrinho.\n");
                    return;
                }
            }
            ItemsPedidos.Add(ipedido);
            Valorpedido += ipedido.Valoritempedido;

        }

        public void removeItemPedido(ItemPedido ipedido)
        {
            foreach (ItemPedido pd in ItemsPedidos)
            {
                if (pd.Equals(ipedido))
                {
                    ItemsPedidos.Remove(ipedido);
                    Valorpedido -= ipedido.Valoritempedido;
                    return;
                }
            }

            Console.WriteLine("Este item não está no carrinho.\n"); 

        }

        public ItemPedido findItemPedido(string itempedido)
        {
            foreach (ItemPedido ipedido in ItemsPedidos)
            {
                if (ipedido.LivroPedido.Titulo.Equals(itempedido, StringComparison.OrdinalIgnoreCase))
                {
                    return ipedido;
                }
            }

            return null;
        }

        public int Codpedido { get => codpedido; set => codpedido = value; }
        public float Valorpedido { get => valorpedido; set => valorpedido = value; }
        internal List<ItemPedido> ItemsPedidos { get => itemsPedidos; set => itemsPedidos = value; }
    }
}
