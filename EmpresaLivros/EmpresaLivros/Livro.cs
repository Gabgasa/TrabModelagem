using EmpresaLivros.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Livro
    {



        private float valor;
        private string titulo;
        private string conteudo;
        private DateTime datapublicacao;
        [JsonProperty] private Tema tema;
        public static List<Livro> Livros = new List<Livro>();

        public Livro(float valor, string conteudo, string titulo, Tema tema)
        {
            this.Valor = valor;
            this.Titulo = titulo;
            this.datapublicacao = new DateTime();
            this.Tema = tema;
            this.conteudo = conteudo;

            Livros.Add(this);
        }

        public float Valor { get => valor; set => valor = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        internal Tema Tema { get => tema; set => tema = value; }
        public string Conteudo { get => conteudo; set => conteudo = value; }


        //Verifica se o nome do livro já foi cadastrado ou se veio nome em branco.
        public static bool validaLivro(string titulo)
        {
            PublicarLivroView Interface = new PublicarLivroView();

            if (String.IsNullOrEmpty(titulo))
            {
                Interface.erroLivro();
                return false;
            }

            foreach (Livro livro in Livros)
            {
                if (titulo.Equals(livro.titulo, StringComparison.OrdinalIgnoreCase))
                {
                    Interface.erroLivroJaCadastrado(titulo);
                    return false;
                }
            }

            return true;
        }

        public static bool validaValor(string valor)
        {
            PublicarLivroView Interface = new PublicarLivroView();
            if (String.IsNullOrEmpty(valor))
            {
                Interface.erroValor();
                return false;
            }

            try
            {
                float.Parse(valor);
            }
            catch
            {
                Interface.erroValor();
                return false;
            }
            return true;
        }

        public static bool validaConteudo(string conteudo)
        {
            if (String.IsNullOrEmpty(conteudo))
                return false;
            else
                return true;
        }

        public static List<Livro> procuraLivrosTema(List<Livro> livros, string tema)
        {
            ListarLivrosTemaView Interface = new ListarLivrosTemaView();

            if (String.IsNullOrEmpty(tema))
            {
                Interface.listaTodosLivros();
                return Livros;
            }

            foreach (Livro lv in Livros)
            {
                if (tema.Equals(lv.Tema.NomeTema, StringComparison.OrdinalIgnoreCase))
                {
                    livros.Add(lv);
                }
            }
            Interface.listarLivrosSucesso(tema);
            return livros;
        }

    }
}
