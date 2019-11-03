using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmpresaLivros
{
    class TemaDao
    {

        public static void loadTemas()
        {
            using (StreamReader file = new StreamReader(@"C:\Users\gab_g\OneDrive\Documentos\GitHub\TrabModelagem\EmpresaLivros\EmpresaLivros\Json\Temas.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Tema> tema = (List<Tema>)serializer.Deserialize(file, typeof(List<Tema>));

            }
        }

        public static void saveTemas()
        {
            using (StreamWriter file = File.CreateText(@"C:\Users\gab_g\OneDrive\Documentos\GitHub\TrabModelagem\EmpresaLivros\EmpresaLivros\Json\Temas.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                file.Flush();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, Tema.listaTemas);
            }
        }
    }
}
