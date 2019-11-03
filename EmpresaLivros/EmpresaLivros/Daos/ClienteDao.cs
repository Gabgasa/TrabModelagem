using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmpresaLivros
{
    class ClienteDao
    {

        public static void loadClientes()
        {
            using (StreamReader file = new StreamReader(@"C:\Users\gab_g\OneDrive\Documentos\GitHub\TrabModelagem\EmpresaLivros\EmpresaLivros\Json\Clientes.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Cliente> cliente = (List<Cliente>)serializer.Deserialize(file, typeof(List<Cliente>));

            }
        }

        public static void saveClientes()
        {
            using (StreamWriter file = File.CreateText(@"C:\Users\gab_g\OneDrive\Documentos\GitHub\TrabModelagem\EmpresaLivros\EmpresaLivros\Json\Clientes.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                file.Flush();
                serializer.Serialize(file, Cliente.listaClientes);
            }
        }
    }
}
