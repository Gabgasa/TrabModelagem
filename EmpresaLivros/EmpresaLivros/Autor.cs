﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Autor : Pessoa
    {
        private string contaRecebimento;

        public Autor(int id, string nome, string usuario, string senha, string contaRecebimento) : base(id, nome, usuario, senha)
        {
            this.ContaRecebimento = contaRecebimento;
        }

        public string ContaRecebimento { get => contaRecebimento; set => contaRecebimento = value; }
    }
}
