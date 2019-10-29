using System;



namespace EmpresaLivros
{
    class Controlador
    {
        static void Main(string[] args)
        {
            Controlador.Inicio();            
            
        }

        public static void Inicio()
        {
            ControladorPublicarLivro PublicarLivro = new ControladorPublicarLivro();
            ControladorListarLivrosTema ListarLivrosTema = new ControladorListarLivrosTema();
            ControladorSugestao Sugestao = new ControladorSugestao();
            ControladorPagamento Pagamento = new ControladorPagamento();
            ControladorInterface Interface = new ControladorInterface();

            Autor autor = new Autor(1, "Gabriel", "Evinie", "123456");
            Cliente cliente = new Cliente(2, "Gabriel", "Evinie2", "456123");
            Tema tema = new Tema("Ciencia");

        Interface.menuInicial();
            switch (Console.ReadLine())
            {
                case "1":
                    PublicarLivro.Publicar(autor);
                    break;
                case "2":
                    ListarLivrosTema.ListarLivros();
                    break;
                case "3":
                    Pagamento.Pagamento(cliente);
                    break;
                case "4":
                    return;
            }
        }
    }
}