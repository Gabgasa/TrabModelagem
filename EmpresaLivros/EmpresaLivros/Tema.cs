using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaLivros
{
    class Tema
    {
        private string nomeTema;
        private static List<Tema> listaTemas = new List<Tema>();
        private List<Tema> subTemas = new List<Tema>();

        public Tema(string nomeTema)
        {
            this.nomeTema = nomeTema;
            listaTemas.Add(this);
        }


        //Stub
        public static bool validaTema(string nomeTema)
        {
            ControladorInterface Interface = new ControladorInterface();
            if (String.IsNullOrEmpty(nomeTema))
            {
                Interface.erroTema();
                return false;
            }

            foreach (Tema tema in listaTemas)
            {
                if (nomeTema.Equals(tema.nomeTema, StringComparison.OrdinalIgnoreCase))
                    break;
                Interface.erroTema();
                return false;
            }
            
            return true;
        }
    }
}
