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
            //LivroDao.loadBooks();
            //TemaDao.loadTemas();
            ClienteDao.loadClientes();
            AutorDao.loadAutores();

           
                



            Inicio();
        }

        public static void Inicio()
        {
            ControladorPublicarLivro PublicarLivro = new ControladorPublicarLivro();
            ControladorListarLivrosTema ListarLivrosTema = new ControladorListarLivrosTema();
            ControladorSugestao ControleSugestao = new ControladorSugestao();
            ControladorPagamento ControlePagamento = new ControladorPagamento();

            MenuInicialView Interface = new MenuInicialView();


            Interface.menuInicial();
            switch (Console.ReadLine())
            {
                case "1":
                    PublicarLivro.Publicar(Autor.listaAutores[0]);
                    break;
                case "2":
                    ListarLivrosTema.ListarLivros();
                    break;
                case "3":
                    ControlePagamento.realizarPagamento(Cliente.listaClientes[2]);
                    break;
                case "4":
                    ControleSugestao.gerarSugestao(Cliente.listaClientes[2]);
                    break;
                case "5":
                    return;
            }
        }
    }
}