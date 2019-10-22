using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Promocao
    {
        private int idpromocao;
        private float percentualDesc;
        private DateTime dtinicio;
        private DateTime dtfim;

        public Promocao(int idpromocao, float percentualDesc, DateTime dtinicio, DateTime dtfim)
        {
            this.Idpromocao = idpromocao;
            this.PercentualDesc = percentualDesc;
            this.Dtinicio = dtinicio;
            this.Dtfim = dtfim;
        }

        public int Idpromocao { get => idpromocao; set => idpromocao = value; }
        public float PercentualDesc { get => percentualDesc; set => percentualDesc = value; }
        public DateTime Dtinicio { get => dtinicio; set => dtinicio = value; }
        public DateTime Dtfim { get => dtfim; set => dtfim = value; }
    }
}
