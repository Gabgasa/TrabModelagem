using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class ItemPedido
    {
        private int coditempedido;
        private float valoritempedido;
        private Livro livroPedido;

        public ItemPedido(int coditempedido, float valoritempedido, Livro livroPedido)
        {
            this.Coditempedido = coditempedido;
            this.Valoritempedido = valoritempedido;
            this.LivroPedido = livroPedido;

        }

        public int Coditempedido { get => coditempedido; set => coditempedido = value; }
        public float Valoritempedido { get => valoritempedido; set => valoritempedido = value; }
        internal Livro LivroPedido { get => livroPedido; set => livroPedido = value; }
    }
}
