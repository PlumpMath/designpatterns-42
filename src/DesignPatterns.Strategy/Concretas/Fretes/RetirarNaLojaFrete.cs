using DesignPatterns.Strategy.Domain;
using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Concretas.Fretes
{
    public class RetirarNaLojaFrete : IFrete
    {
        public double Calcular(PedidoDeCompra pedido)
        {
            return 0;
        }
    }
}
