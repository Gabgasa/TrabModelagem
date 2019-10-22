using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class ItemPedido
    {
        private int coditempedido;
        private float valoritempedido;

        public ItemPedido(int coditempedido, float valoritempedido)
        {
            Coditempedido = coditempedido;
            Valoritempedido = valoritempedido;
        }

        public int Coditempedido { get => coditempedido; set => coditempedido = value; }
        public float Valoritempedido { get => valoritempedido; set => valoritempedido = value; }
    }
}
