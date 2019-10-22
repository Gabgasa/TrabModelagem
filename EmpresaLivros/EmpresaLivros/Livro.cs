using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Livro
    {
        private float valor;
        private string titulo;
        private string datapublicacao;

        public Livro(float valor, string titulo, string datapublicacao)
        {
            this.Valor = valor;
            this.Titulo = titulo;
            this.Datapublicacao = datapublicacao;
        }

        public float Valor { get => valor; set => valor = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Datapublicacao { get => datapublicacao; set => datapublicacao = value; }
    }
}
