using System;



namespace EmpresaLivros
{
    class Controlador
    {
        static void Main(string[] args)
        {
           Pessoa p = new Pessoa(1, "b", "c", "d");
            Autor a1 = new Autor(1, "b", "c", "d", "123-456");
            Console.WriteLine(a1.ContaRecebimento);

        }
    }
}