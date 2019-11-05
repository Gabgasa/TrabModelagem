using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Sugestao
    {
        public List<Livro> geraSugestao(Cliente cliente)
        {
            List<string> listaTemas = new List<string>();
            List<string> temasEscolhidos = new List<string>();
            List<Livro> resposta = new List<Livro>();

            foreach (Livro lv in cliente.LivrosComprados)
            {
                if(!listaTemas.Contains(lv.Tema.NomeTema))
                    listaTemas.Add(lv.Tema.NomeTema);
            }



            if (listaTemas.Count >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Random random = new Random();
                    int index = random.Next(0, listaTemas.Count - 1);
                    temasEscolhidos.Add(listaTemas[index]);
                }

                foreach (Livro lv in Livro.Livros)
                {
                    if (!cliente.LivrosComprados.Contains(lv) && temasEscolhidos.Contains(lv.Tema.NomeTema))
                    {
                        resposta.Add(lv);
                        temasEscolhidos.Remove(lv.Tema.NomeTema);
                    }

                }
                return resposta;
            }
            else if (listaTemas.Count == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    Random random = new Random();
                    int index = random.Next(0, listaTemas.Count - 1);
                    temasEscolhidos.Add(listaTemas[index]);
                    temasEscolhidos.Add(listaTemas[index]);
                }

                foreach (Livro lv in Livro.Livros)
                {
                    if (!cliente.LivrosComprados.Contains(lv) && temasEscolhidos.Contains(lv.Tema.NomeTema))
                    {
                        resposta.Add(lv);
                        temasEscolhidos.Remove(lv.Tema.NomeTema);
                    }

                }
                return resposta;
            }

            else if (listaTemas.Count == 1)
            {
                foreach (Livro lv in Livro.Livros)
                {
                    if (!cliente.LivrosComprados.Contains(lv) && listaTemas.Contains(lv.Tema.NomeTema))
                    {
                        
                        resposta.Add(lv);
                    }

                }
                return resposta;
            }

            else
            {
                return null;
            }

            


            
        }
       
    }

    
}
