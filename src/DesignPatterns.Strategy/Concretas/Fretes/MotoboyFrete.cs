using DesignPatterns.Strategy.Domain;
using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Concretas.Fretes
{
    public class MotoboyFrete : IFrete
    {
        public double Calcular(PedidoDeCompra pedido)
        {
            return 2;
        }
    }
}
