using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lachonete
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string  NomeCliente { get; set; }
        public string TelefoneCliente { get; set; }


       
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
