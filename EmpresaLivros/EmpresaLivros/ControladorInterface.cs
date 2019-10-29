﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class ControladorInterface
    {
        public ControladorInterface()
        {
        }

        public void menuInicial()
        {
            Console.WriteLine("Bem vindo ao aplicativo de venda de Livros");
            Console.WriteLine("Escolha uma das seguintes opções");
            Console.WriteLine("\t1 - Publicar um Livro");
            Console.WriteLine("\t2 - Buscar livros baseado em um tema");
            Console.WriteLine("\t3 - Comprar um livro");
            Console.WriteLine("\t4 - Sair");
        }

        public void cadastroBancario()
        {
            Console.WriteLine("Informações bancárias não cadastradas, favor colocar os dados bancários a seguir.");
            Console.WriteLine("Informe seu cpf, sua conta e sua agencia");
        }

        public void dadosCadastroLivro()
        {
            Console.WriteLine("Preencha os os dados na seguinte ordem:");
            Console.WriteLine("\t1 - Titulo do livro.");
            Console.WriteLine("\t2 - Tema do livro.");
            Console.WriteLine("\t3 - Valor do livro.");

        }

        public void erroTema()
        {
            Console.WriteLine("O tema inserido é inválido ou não existe");
        }

        public void erroValor()
        {
            Console.WriteLine("O valor inserido é inválido ou está em branco");
        }

        public void erroLivro()
        {
            Console.WriteLine("O livro inserido é inválido");
        }

        public void sucessoCadastro(string titulo)
        {
            Console.WriteLine($"O livro {titulo} foi cadastrado com sucesso.\n");
        }

        public void erroLivroJaCadastrado(string titulo)
        {
            Console.WriteLine($"Um livro com o título {titulo} já foi cadastrado.");
        }

        public void uploadLivro()
        {
            Console.WriteLine("Por favor escreva o conteúdo do livro a seguir");
        }


    }
}
