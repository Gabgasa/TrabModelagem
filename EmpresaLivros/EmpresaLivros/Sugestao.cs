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
            bool escolheLivros = true;

            foreach (Livro lv in cliente.LivrosComprados)
            {
                if(!listaTemas.Contains(lv.Tema.NomeTema))
                    listaTemas.Add(lv.Tema.NomeTema);
            }



            if (listaTemas.Count >= 3 && escolheLivros == true)
            {
                escolheLivros = false;
                for (int i = 0; i < 3; i++)
                {
                    Random random = new Random();
                    int index = random.Next(0, listaTemas.Count - 1);
                    temasEscolhidos.Add(listaTemas[index]);
                    listaTemas.Remove(listaTemas[index]);
                }

                foreach (Livro lv in Livro.Livros)
                {
                    if (!cliente.LivrosComprados.Equals(lv) && temasEscolhidos.Equals(lv.Tema.NomeTema))
                    {
                        Console.WriteLine("c");
                        resposta.Add(lv);
                        temasEscolhidos.Remove(lv.Tema.NomeTema);
                    }

                }
                return resposta;
            }
            else if (listaTemas.Count == 2 && escolheLivros == true)
            {
                
                escolheLivros = false;
                for (int i = 0; i < 2; i++)
                {
                    Random random = new Random();
                    int index = random.Next(0, listaTemas.Count - 1);
                    temasEscolhidos.Add(listaTemas[index]);
                    listaTemas.Remove(listaTemas[index]);
                }
                Console.WriteLine(temasEscolhidos.Count);
                Console.WriteLine("Temas escolhidos ---- " + temasEscolhidos[0] + " / " + temasEscolhidos[1]);

                foreach (Livro lv in Livro.Livros)
                {
                    //Console.WriteLine(cliente.LivrosComprados.Contains(lv) == false);
                    //Console.WriteLine("Tema livro avaliado: " + lv.Tema.NomeTema + "---- Titulo livro avaliado: " + lv.Titulo);
                    //Console.WriteLine(lv.Titulo);
                    if (cliente.LivrosComprados.Contains(lv) == false)
                    {
                        if (temasEscolhidos.Contains(lv.Tema.NomeTema) == true)
                        {

                            Livro aux = lv;
                            resposta.Add(aux);
                        }
                    }
            
                  
                    

                }
                return resposta;
            }

            else if (listaTemas.Count == 1 && escolheLivros == true)
            {
                escolheLivros = false;
                foreach (Livro lv in Livro.Livros)
                {
                    if (!cliente.LivrosComprados.Contains(lv) && listaTemas.Contains(lv.Tema.NomeTema))
                    {
                        Console.WriteLine("a");  
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
