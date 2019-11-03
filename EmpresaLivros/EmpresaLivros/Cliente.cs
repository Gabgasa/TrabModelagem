using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    

    class Cliente : Pessoa
    {
        private List<Livro> livrosComprados = new List<Livro>();
        public static List<Cliente> listaClientes = new List<Cliente>();

        public Cliente(int id, string nome, string usuario, string senha) : base(id, nome, usuario, senha)
        {
            listaClientes.Add(this);
        }

    }
}
