using System;
using DesignPatterns.Strategy.Concretas;
using DesignPatterns.Strategy.Concretas.Fretes;
using DesignPatterns.Strategy.Domain;
using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new PedidoDeCompra
            {
                Valor = 200,
                NomeDoProduto = "Tv LCD",
                TipoDeEntrega = TipoDeEntrega.Correios
            };

            var valorDoFrete = Calcular(new CorreiosFrete(), pedido);
            Console.WriteLine("O frete custará R$ {0}", valorDoFrete);
            Console.ReadKey();
        }

        static double Calcular(IFrete frete, PedidoDeCompra pedido)
        {
            var calculador = new CalculadorFrete(frete);
            return calculador.CalcularFrete(pedido);
        }
    }
}
