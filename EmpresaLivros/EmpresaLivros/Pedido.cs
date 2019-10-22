using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Pedido
    {
        private int codpedido;
        private float valorpedido;

        public Pedido(int codpedido, float valorpedido)
        {
            Codpedido = codpedido;
            Valorpedido = valorpedido;
        }

        public int Codpedido { get => codpedido; set => codpedido = value; }
        public float Valorpedido { get => valorpedido; set => valorpedido = value; }
    }
}
