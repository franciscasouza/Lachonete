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
        public string msg { get; set; }
        public Produtos produto = new Produtos();



        public void CardapioPedido(int id)
        {


            if (produto.IdProduto == 1)
            {
                produto.Descricao = "Trio Slides - Mini Pizzas";
                produto.ValorUnitatio = 18.70;

            }
            else if (produto.IdProduto == 2)
            {
                produto.Descricao = "Trio Sliders - Ovomaltine ";
                produto.ValorUnitatio = 22.50;
            }
            else if (produto.IdProduto == 3)
            {
                produto.Descricao = "Hut Doce de Leite ";
                produto.ValorUnitatio = 19.20;
            }
            else if (produto.IdProduto == 4)
            {
                produto.Descricao = "Hut Ovomaltine ";
                produto.ValorUnitatio = 24.50;
            }
            else if (produto.IdProduto == 5)
            {
                produto.Descricao = "Hut Brigadeiro - PPP ";
                produto.ValorUnitatio = 21.30;
            }
            else if (produto.IdProduto == 6)
            {
                produto.Descricao = "Hut Brigadeiro - M ";
                produto.ValorUnitatio = 48.70;
            }
            else if (produto.IdProduto == 7)
            {
                produto.Descricao = "Hut Brigadeiro - G ";
                produto.ValorUnitatio = 68.30;
            }
            else if (produto.IdProduto == 8)
            {
                produto.Descricao = "Água Mineral ";
                produto.ValorUnitatio = 5.10;
            }
            else if (produto.IdProduto == 9)
            {
                produto.Descricao = "Aquarius Fresh ";
                produto.ValorUnitatio = 6.30;
            }
            else if (produto.IdProduto == 10)
            {
                produto.Descricao = "Refri Lata ";
                produto.ValorUnitatio = 6.30;
            }
            else if (produto.IdProduto == 11)
            {
                produto.Descricao = "Cerveja Lata ";
                produto.ValorUnitatio = 8.40;
            }
            else if (produto.IdProduto == 12)
            {
                produto.Descricao = "Cerveja LN ";
                produto.ValorUnitatio = 8.90;
            }
            else
            {
                msg = "Código do Produto não Encontrado";
            }
        }
        
       
    }
}
