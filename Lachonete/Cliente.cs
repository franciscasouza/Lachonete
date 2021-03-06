
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
using System.Windows.Forms;

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

        public Cliente(){}

        public bool SalvarListCliente(List<Cliente> lista, string path)
        {
            var strJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
            return SalvarArquivo(strJson, path);
        }

        public static Cliente ListarClient(string path)
        {
            var strJson = OpenFileCliente(path);
            if (strJson.Substring(0,5) != "Falha") 
            {
                return JsonConvert.DeserializeObject<Cliente>(strJson);
            }
            else
            {
                var cliente = new Cliente();
                cliente.NomeCliente = strJson;
                return cliente;
            }
        }
        
        public static List<Cliente> carregarCliente(string path)
        {
            var strJson = OpenFileCliente(path);
            if (strJson.Substring(0,5) !="Falha")
            {
                return JsonConvert.DeserializeObject<List<Cliente>>(strJson);
            }
            else
            {
                var listClientes = new List<Cliente>();
                var cliente = new Cliente();
                cliente.NomeCliente = strJson;
                listClientes.Add(cliente);
                cliente.NomeCliente = strJson;
                return listClientes;
            }
        }

        private bool SalvarArquivo(string strJson, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(strJson);
                }

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha", ex.Message);
            }

            return false;
        }
        
        private static string OpenFileCliente(string path)
        {
            try
            {
                var strJson = "";
                using(StreamReader sr =  new StreamReader(path))
                {
                    strJson = sr.ReadToEnd();
                }

                return strJson;
            }
            catch (Exception ex)
            {

                return "Falha" + ex.Message;
            }
        }

    }
}
