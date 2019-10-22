using System;



namespace EmpresaLivros
{
    class Controlador
    {
        static void Main(string[] args)
        {
            Pedido p = new Pedido(1, 2);
            Console.WriteLine($"{p.Codpedido}, {p.Valorpedido}");
        }
    }
}