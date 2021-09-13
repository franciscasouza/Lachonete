
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Lachonete
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string  NomeCliente { get; set; }
        public string TelefoneCliente { get; set; }

        public List<Cliente> ListarClientes()
        {
            
            var json = File.ReadAllText(@"C:/Users/Aluno/source/repos/franciscasouza/Lachonete/Lachonete/Bd/BdCliente.json");
            var listCliente = JsonConvert.DeserializeObject<List<Cliente>>(json);

            return listCliente;

        }

       
        public Cliente(int id, string nome, string telefone)
        {
            IdCliente = id;
            NomeCliente = nome;
            TelefoneCliente = telefone;
        }

        public Cliente()
        {

        }
    }
}
