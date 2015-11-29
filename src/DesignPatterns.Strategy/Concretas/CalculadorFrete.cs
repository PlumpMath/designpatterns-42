using DesignPatterns.Strategy.Domain;
using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Concretas
{
    public class CalculadorFrete : ICalculadorFrete
    {
        private readonly IFrete frete;

        public CalculadorFrete(IFrete frete)
        {
            this.frete = frete;
        }

        public double CalcularFrete(PedidoDeCompra pedido)
        {
            return frete.Calcular(pedido);
        }
    }
}
