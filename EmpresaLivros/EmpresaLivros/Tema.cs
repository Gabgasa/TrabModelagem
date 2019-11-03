using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Tema
    {
        private string nomeTema;
        private string temaPai;
        public static List<Tema> listaTemas = new List<Tema>();
        public List<String> subTemas = new List<String>();

        
        public Tema(string nomeTema, string nomePai)
        {


            this.NomeTema = nomeTema;
            this.TemaPai = nomePai;
            Tema tema = procuraTema(nomePai);
            tema.subTemas.Add(this.NomeTema);
            listaTemas.Add(this);

        }
        [JsonConstructor]
        public Tema(string nomeTema)
        {

            listaTemas.Add(this);
            this.NomeTema = nomeTema;
        }
        

        public string NomeTema { get => nomeTema; set => nomeTema = value; }
        public string TemaPai { get => temaPai; set => temaPai = value; }

        public static Tema procuraTema(string nomeTema)
        {
            foreach (Tema tema in listaTemas)
            {
                //Console.WriteLine(nomeTema);
                if (nomeTema.Equals(tema.NomeTema, StringComparison.OrdinalIgnoreCase))
                {
                    return tema;
                }
            }

            return null;
        }

        //Stub
        public static bool validaTema(string nomeTema)
        {
            
            PublicarLivroView Interface = new PublicarLivroView();
            if (String.IsNullOrEmpty(nomeTema))
            {
                Console.WriteLine(nomeTema);
                Interface.erroTema();
                return false;
            }

            foreach (Tema tema in listaTemas)
            {
                //Console.WriteLine(nomeTema);
                if (nomeTema.Equals(tema.NomeTema, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                    
               
            }
            Interface.erroTema();
            return false;
        }
    }
}
