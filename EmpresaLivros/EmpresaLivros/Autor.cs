using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{

    class Autor : Pessoa
    {
        private string contaRecebimento;
        [JsonProperty] private List<Livro> livrosPublicados = new List<Livro>();
        public static List<Autor> listaAutores = new List<Autor>();

        [JsonConstructor]
        public Autor(int id, string nome, string usuario, string senha, string contaRecebimento) : base(id, nome, usuario, senha)
        {
            this.ContaRecebimento = contaRecebimento;
            listaAutores.Add(this);
        }

        public Autor(int id, string nome, string usuario, string senha) : base(id, nome, usuario, senha)
        {
            listaAutores.Add(this);
        }

        public string ContaRecebimento { get => contaRecebimento; set => contaRecebimento = value; }

        public void adicionarLivroPublicado(Livro livro)
        {
            livrosPublicados.Add(livro);
        }

        public void removerLivroPublicado(Livro livro)
        {
            livrosPublicados.Remove(livro);
        }
    }
}
