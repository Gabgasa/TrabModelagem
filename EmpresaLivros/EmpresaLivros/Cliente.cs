using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Cliente : Pessoa
    {
        public Cliente(int id, string nome, string usuario, string senha) : base(id, nome, usuario, senha)
        {
        }

    }
}
