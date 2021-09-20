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
        public CadCliente()
        {
            InitializeComponent();
            c.ListarClientes();
        }

    
       

        private void button1_Click(object sender, EventArgs e)
        {

           int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;
           string telefone = txtTelefone.Text;

            c = new Cliente(id, nome, telefone);

            Pedido pedido = new Pedido(c);
            pedido.Show();
        }
    }
}
