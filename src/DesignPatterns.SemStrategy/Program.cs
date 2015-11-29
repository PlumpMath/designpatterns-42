using System;
using DesignPatterns.SemStrategy.Domain;

namespace DesignPatterns.SemStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadorDeFrete = new CalculadorFrete();
            var pedido = new PedidoDeCompra
            {
                Valor = 200,
                NomeDoProduto = "Tv LCD",
                TipoDeEntrega = TipoDeEntrega.Correios
            };

            var valorDoFrete = calculadorDeFrete.CalcularFrete(pedido);
            Console.WriteLine("O frete custará R$ {0}", valorDoFrete);
            Console.ReadKey();
        }
    }
}
