using System;



namespace EmpresaLivros
{
    class Controlador
    {
        static void Main(string[] args)
        {
            ControladorPublicarLivro PublicarLivro = new ControladorPublicarLivro();
            ControladorListarLivrosTema ListarLivrosTema = new ControladorListarLivrosTema();
            ControladorSugestao Sugestao = new ControladorSugestao();
            ControladorPagamento Pagamento = new ControladorPagamento();


            Console.WriteLine("Bem vindo ao aplicativo de venda de Livros");
            Console.WriteLine("Escolha uma das seguintes opções");
            Console.WriteLine("\t1 - Publicar um Livro");
            Console.WriteLine("\t2 - Buscar livros baseado em um tema");
            Console.WriteLine("\t3 - Comprar um livro");

            switch (Console.ReadLine())
            {
                case "1":
                    PublicarLivro.Publicar();
                    break;
                case "2":
                    ListarLivrosTema.ListarLivros();
                    break;
                case "3":
                    Pagamento.Pagamento();
                    break;
            }
        }
    }
}