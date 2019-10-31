using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Newtonsoft.Json;


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



            using (StreamReader file = new StreamReader(@"C:\Users\gab_g\OneDrive\Documentos\GitHub\TrabModelagem\EmpresaLivros\EmpresaLivros\Json\Livros.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Livro> livro = (List<Livro>)serializer.Deserialize(file, typeof(List<Livro>));
                Console.WriteLine(livro[1].Titulo);
            }





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