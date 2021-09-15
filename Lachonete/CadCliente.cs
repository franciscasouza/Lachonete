using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lachonete
{
    public partial class CadCliente : Form
    {
        List<Cliente> listarClientes = new List<Cliente>();

        Cliente cliente = new Cliente();
        public CadCliente()
        {
            InitializeComponent();
            ExibirDados();
        }



        private void CarregarDados()
        {
            Cliente c = new Cliente();
            c.IdCliente = int.Parse(txtId.Text);
            c.NomeCliente = txtNome.Text;
            c.TelefoneCliente = txtTelefone.Text;

            listarClientes.Add(c);
            datagridMostrarDados.DataSource = null;
            datagridMostrarDados.DataSource = listarClientes;
        }
       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CarregarDados();
            if (cliente.SalvaListCliente(listarClientes, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados salvos com sucesso");
            }

            txtId.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Cliente c = cliente;

            c.IdCliente = int.Parse(txtId.Text);
            c.NomeCliente = txtNome.Text;
            c.TelefoneCliente = txtTelefone.Text;
            Pedido pedido = new Pedido(c);
            pedido.Show();

        }

        private void ExibirDados()
        {
            listarClientes = Cliente.carregarClientes(@"C:\Bd\BdCliente.json");
            datagridMostrarDados.DataSource = listarClientes;
        }

        private void Editar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow gridViewRow = datagridMostrarDados.Rows[e.RowIndex];
                txtId.Text = gridViewRow.Cells[0].Value.ToString();
                txtNome.Text = gridViewRow.Cells[1].Value.ToString();
                txtTelefone.Text = gridViewRow.Cells[2].Value.ToString();

            }

         
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          

            int id = int.Parse(txtId.Text);
            var elem = listarClientes.Where<Cliente>(x => x.IdCliente == id).FirstOrDefault();
            int index = listarClientes.IndexOf(elem);

           listarClientes[index].IdCliente = id;
           listarClientes[index].NomeCliente = txtNome.Text;
           listarClientes[index].TelefoneCliente = txtTelefone.Text;
            if (cliente.SalvaListCliente(listarClientes, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados salvos");

              
            }
            ExibirDados();

            txtId.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
           



        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var elem = listarClientes.Where<Cliente>(x => x.IdCliente == id).FirstOrDefault();

            listarClientes.Remove(elem);

            if (cliente.SalvaListCliente(listarClientes, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados excluídos com sucesso");
            }

            ExibirDados();

        }
    }
}
