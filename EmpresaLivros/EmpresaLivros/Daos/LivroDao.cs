using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmpresaLivros
{
    class LivroDao
    {
        public static void loadBooks()
        {
            using (StreamReader file = new StreamReader(@"C:\Users\gab_g\OneDrive\Documentos\GitHub\TrabModelagem\EmpresaLivros\EmpresaLivros\Json\Livros.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Livro> livro = (List<Livro>)serializer.Deserialize(file, typeof(List<Livro>));
                

            }
        }

        public static void saveBooks()
        {
            using (StreamWriter file = File.CreateText(@"C:\Users\gab_g\OneDrive\Documentos\GitHub\TrabModelagem\EmpresaLivros\EmpresaLivros\Json\Livros.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                file.Flush();
                serializer.Serialize(file, Livro.Livros);
            }
        }

    }
}
