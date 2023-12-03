using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos.Exemplos
{
    internal class Exemplo02
    {
        public void Executar()
        {
            Pedido pedidoEnzo = new Pedido();
            pedidoEnzo.Nome = "X-Salada";
            pedidoEnzo.Quantidade = 1;
            pedidoEnzo.PrecoUnitario = 25.90;

            Pedido pedidoJonathan = new Pedido();
            pedidoJonathan.Nome = "Bauru";
            pedidoJonathan.Quantidade = 2;
            pedidoJonathan.PrecoUnitario = 27.90;

            Pedido pedidoJoao = new Pedido();
            pedidoJoao.Nome = "caixa de cerveja";
            pedidoJoao.Quantidade = 3;
            pedidoJoao.PrecoUnitario = 46.00;


            double totalPedidoEnzo = pedidoEnzo.CalcularTotalPedido();
            double totalPedidoJoao = pedidoJoao.CalcularTotalPedido();

            double total = totalPedidoEnzo + totalPedidoJoao;

            Console.WriteLine("Total pedido enzo: " + totalPedidoEnzo);
            Console.WriteLine("Total pedido joao: " + totalPedidoJoao);
            Console.WriteLine("Total dos pedidos: " + total);

        }
    }
}
