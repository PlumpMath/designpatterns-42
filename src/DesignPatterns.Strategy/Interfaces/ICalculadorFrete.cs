using DesignPatterns.Strategy.Domain;

namespace DesignPatterns.Strategy.Interfaces
{
    public interface ICalculadorFrete
    {
        double CalcularFrete(PedidoDeCompra pedido);
    }
}
