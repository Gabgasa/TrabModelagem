using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmpresaLivros
{
    class AutorDao
    {

        public static void loadAutores()
        {
            using (StreamReader file = new StreamReader(@"C:\Users\gab_g\OneDrive\Documentos\GitHub\TrabModelagem\EmpresaLivros\EmpresaLivros\Json\Autores.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Autor> autor = (List<Autor>)serializer.Deserialize(file, typeof(List<Autor>));

            }
        }

        public static void saveAutores()
        {
            using (StreamWriter file = File.CreateText(@"C:\Users\gab_g\OneDrive\Documentos\GitHub\TrabModelagem\EmpresaLivros\EmpresaLivros\Json\Autores.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                file.Flush();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, Autor.listaAutores);
            }
        }
    }
}
