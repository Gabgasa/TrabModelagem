using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmpresaLivros
{
    class PessoaDao
    {

        public static void loadPessoas()
        {
            using (StreamReader file = new StreamReader(@"C:\Users\gab_g\OneDrive\Documentos\GitHub\TrabModelagem\EmpresaLivros\EmpresaLivros\Json\Pessoas.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Pessoa> pessoa = (List<Pessoa>)serializer.Deserialize(file, typeof(List<Pessoa>));

            }
        }

        public static void savePessoas()
        {
            using (StreamWriter file = File.CreateText(@"C:\Users\gab_g\OneDrive\Documentos\GitHub\TrabModelagem\EmpresaLivros\EmpresaLivros\Json\Pessoas.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                file.Flush();
                serializer.Serialize(file, Pessoa.listaPessoas);
            }
        }
    }
}
