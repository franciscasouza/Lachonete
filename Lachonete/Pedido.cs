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
        double valor;
       



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

                p.produto = new Produtos();
                p.produto.IdProduto = id;
                p.CardapioPedido(id);
            if (p.produto.IdProduto != 13)
            {
                
                dataGridViewPedido.Rows.Add(p.produto.Descricao, p.produto.ValorUnitatio);
            }
            else
            {
                MessageBox.Show(p.msg);
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            int x = dataGridViewPedido.Rows.Count;

            if (x > 1)
            {
                for (int i = 0; i < x ; i++)
                {
                    valor += double.Parse(dataGridViewPedido.Rows[i].Cells[1].Value.ToString());

                }
            }
            else
            {
                valor = double.Parse(dataGridViewPedido.Rows[0].Cells[1].Value.ToString());
              
            }


            txtPId.Text = "";

            txtTotal.Text = valor.ToString("F2");
            
        }
    }
}
