using System;
using DesignPatterns.SemStrategy.Domain;

namespace DesignPatterns.SemStrategy
{
    public class CalculadorFrete
    {
        public double CalcularFrete(PedidoDeCompra pedido)
        {
            switch (pedido.TipoDeEntrega)
            {
                case TipoDeEntrega.Correios:
                    return CalcularFreteCorreios(pedido);
                case TipoDeEntrega.MotoBoy:
                    return CalcularFreteMotoboy(pedido);
                case TipoDeEntrega.RetirarNaLoja:
                    return 0;
                case TipoDeEntrega.Sedex:
                    return CalcularFreteSedex(pedido);
                default:
                    throw new Exception("Método de entrega não existe");
            }
        }

        private static double CalcularFreteSedex(PedidoDeCompra pedido)
        {
            return pedido.Valor * 0.20;
        }

        private static double CalcularFreteMotoboy(PedidoDeCompra pedido)
        {
            return 2;
        }

        private static double CalcularFreteCorreios(PedidoDeCompra pedido)
        {
            return pedido.Valor * 0.10;
        }
    }
}
