using DesignPatterns.Strategy.Domain;
using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Concretas.Fretes
{
    public class SedexFrete : IFrete
    {
        public double Calcular(PedidoDeCompra pedido)
        {
            return pedido.Valor * 0.20;
        }
    }
}
