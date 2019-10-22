using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Pessoa
    {
        private int id;
        private string nome;
        private string usuario;
        private string senha;

        public Pessoa(int id, string nome, string usuario, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Usuario = usuario;
            this.Senha = senha;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
