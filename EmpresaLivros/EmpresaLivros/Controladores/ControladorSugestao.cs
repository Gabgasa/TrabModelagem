using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class ControladorSugestao
    {
        public ControladorSugestao()
        {
        }

        public void gerarSugestao(Cliente cliente)
        {
            Sugestao sugestao = new Sugestao();
            List<Livro> resposta = sugestao.geraSugestao(cliente);
            if (resposta != null)
            {
                Views.GerarSugestaoView.gerarSugestao(resposta);
            }
            else
            {
                Views.GerarSugestaoView.erroSugestao();
            }
            Controlador.Inicio();
        }
    }
}
