using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lachonete
{
    public class Pedidos
    {
        public int IdPedido { get; set; }
        public DateTime dataPedido { get; set; }
        public double ValorTotal { get; set; }

        public Produtos produto;

        List<Produtos> produtos = new List<Produtos>();

        public void CardapioPedido(int id)
        {
            if (produto.IdProduto == 001)
            {
                produto.descricao = "Mini pizzas recheada de brigadeiro ou doce de leite";
                produto.ValorUnitatio = 18.70;
            }
            else if (produto.IdProduto == 002)
            {
                produto.descricao = "Ovomaltine ";
                produto.ValorUnitatio = 22.50;
            }
        }
    }
}
