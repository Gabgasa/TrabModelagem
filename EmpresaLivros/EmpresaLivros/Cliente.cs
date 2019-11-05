using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    

    class Cliente : Pessoa
    {
        private float balanco;
        private List<Livro> livrosComprados = new List<Livro>();
        public static List<Cliente> listaClientes = new List<Cliente>();

        public List<Livro> LivrosComprados { get => livrosComprados; set => livrosComprados = value; }
        public float Balanco { get => balanco; set => balanco = value; }

        [JsonConstructor]
        public Cliente(int id, string nome, string usuario, string senha, float balanco, List<Livro> livroscomprados) : base(id, nome, usuario, senha)
        {
            listaClientes.Add(this);
            this.Balanco = balanco;
            this.LivrosComprados = livroscomprados;
        }

        public void addLivro(Livro livro)
        {
            LivrosComprados.Add(livro);
        }

        public bool verificaLivro(Livro livro)
        {
            foreach (Livro lv in LivrosComprados)
            {
                if (lv.Equals(livro))
                {
                    Views.PagamentoView.livroJaComprado();
                    return false;
                }
            }
            return true;
        }

    }
}
