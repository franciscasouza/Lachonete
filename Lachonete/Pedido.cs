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
    public partial class Pedido : Form
    {
        Cliente c = new Cliente();
        Pedidos p = new Pedidos();
        Produtos pd = new Produtos();
        public Pedido(Cliente cliente)
        {

            InitializeComponent();

            c = cliente;

            ChamarCliente();

        }

        public void ChamarCliente()
        {
            txtPnome.Text = c.NomeCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtPId.Text);
            p.CardapioPedido(id);

            string produto = pd.descricao;
            double valor = pd.ValorUnitatio;

            dataGridViewPedido.Rows.Add(produto, valor);

        }
    }
}
