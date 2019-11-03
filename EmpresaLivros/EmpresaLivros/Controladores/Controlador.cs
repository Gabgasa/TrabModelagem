using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace EmpresaLivros
{
    class Controlador
    {
        static void Main(string[] args)
        {                     
            LivroDao.loadBooks();
            TemaDao.loadTemas();


            Inicio();



        }

        public static void Inicio()
        {
            ControladorPublicarLivro PublicarLivro = new ControladorPublicarLivro();
            ControladorListarLivrosTema ListarLivrosTema = new ControladorListarLivrosTema();
            ControladorSugestao Sugestao = new ControladorSugestao();
            ControladorPagamento Pagamento = new ControladorPagamento();

            MenuInicialView Interface = new MenuInicialView();

           

         //Carregandom todos os dados
           // PessoaDao.loadPessoas();
           // AutorDao.loadAutores();
           // ClienteDao.loadClientes();


            Autor autor = new Autor(1, "Gabriel", "Evinie", "123456");
            Cliente cliente = new Cliente(2, "Gabriel", "Evinie2", "456123");


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
                    Sugestao.gerarSugestao(cliente);
                    break;
                case "5":
                    return;
            }
        }
    }
}