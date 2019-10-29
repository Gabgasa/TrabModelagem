﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class ControladorPublicarLivro
    {
        ControladorInterface Interface = new ControladorInterface();
        Controlador controlador = new Controlador();


        public ControladorPublicarLivro()
        {
        }

        public void Publicar(Autor autor)
        {
            //Console.WriteLine("Você selecionou publicar livro\n");
            if (String.IsNullOrEmpty(autor.ContaRecebimento))
            {
                cadastroBancario(autor);
                Publicar(autor);
            }
            else
            {
                publicaLivro(autor);
                Controlador.Inicio();
            }
        }

        private void cadastroBancario(Autor autor)
        {
            Interface.cadastroBancario();
            autor.ContaRecebimento = Console.ReadLine();
        }

        private void publicaLivro(Autor autor)
        {
            Interface.dadosCadastroLivro();
            string titulo = Console.ReadLine();
            string tema = Console.ReadLine();
            string valor = Console.ReadLine();

            if (Livro.validaLivro(titulo) && Tema.validaTema(tema) && Livro.validaValor(valor))
            {
                adicionaLivro(autor, valor, titulo, tema);
            }
            else
            {
                publicaLivro(autor);
            }
        }

        private void adicionaLivro(Autor autor, string valor, string titulo, string tema)
        {
            Interface.uploadLivro();
            String conteudo = Console.ReadLine();
            Tema temaLivro = new Tema(tema);
            Livro novoLivro = new Livro(float.Parse(valor), conteudo, titulo, temaLivro);
            autor.adicionarLivroPublicado(novoLivro);
            Interface.sucessoCadastro(titulo);
        }
    }
}
