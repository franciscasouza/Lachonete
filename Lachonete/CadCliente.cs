using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lachonete
{
    public partial class CadCliente : Form
    {
        Cliente c = new Cliente();
        List<Cliente> listarClientes = new List<Cliente>();
        public CadCliente()
        {
            InitializeComponent();
            ExibirDados();


        }

        private void CarregarDados()
        {
            var MaxId = listarClientes.Max(x => x.IdCliente);
            c.IdCliente = MaxId + 1;
            c.NomeCliente = txtNome.Text;
            c.TelefoneCliente = txtTelefone.Text;
            listarClientes.Add(c);

            txtId.Text = c.IdCliente.ToString();            
            dataGridViewDados.DataSource = null;            
            dataGridViewDados.DataSource = listarClientes;
            
        }

        private void ExibirDados()
        {
           
           listarClientes = Cliente.carregarCliente(@"C:\Bd\BdCliente.json");
           
           dataGridViewDados.DataSource = listarClientes;
            
        }
       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CarregarDados();

            if (c.SalvarListCliente(listarClientes, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados Salvo com sucesso !");
            }

            txtNome.Text = "";
            txtTelefone.Text = "";
        }

        private void Editar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow gridViewRow = dataGridViewDados.Rows[e.RowIndex];
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

            listarClientes[index].NomeCliente = txtNome.Text;
            listarClientes[index].TelefoneCliente = txtTelefone.Text;
            if (c.SalvarListCliente(listarClientes, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados salvols");

            }
            ExibirDados();
            txtNome.Text = "";
            txtTelefone.Text = "";

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var elem = listarClientes.Where<Cliente>(x => x.IdCliente == id).FirstOrDefault();
            listarClientes.Remove(elem);

            if (c.SalvarListCliente(listarClientes, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados exluidos com sucesso !");

            }
            ExibirDados();
        }
    }
}
