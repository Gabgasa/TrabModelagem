using System;



namespace EmpresaLivros
{
    class Controlador
    {
        private ControladorPublicarLivro PublicarLivro = new ControladorPublicarLivro();
        private ControladorListarLivrosTema ListarLivrosTema = new ControladorListarLivrosTema();
        private ControladorSugestao Sugestao = new ControladorSugestao();
        private ControladorPagamento Pagamento = new ControladorPagamento();


        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao aplicativo de venda de Livros");
            Console.WriteLine("Escolha uma das seguintes opções");
            Console.WriteLine("\t1 - Publicar um Livro");
            Console.WriteLine("\t2 - Buscar um livro baseado em um tema");
            Console.WriteLine("\t3 - Comprar um livro");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Voce escolheu 1");
                    
                    break;
                case "2":
                    Console.WriteLine("Voce escolheu 2");
                    break;
                case "3":
                    Console.WriteLine("Voce escolheu 3");
                    break;
            }
        }
    }
}