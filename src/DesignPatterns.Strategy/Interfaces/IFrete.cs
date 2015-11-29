using DesignPatterns.Strategy.Domain;

namespace DesignPatterns.Strategy.Interfaces
{
    public interface IFrete
    {
        double Calcular(PedidoDeCompra pedido);
    }
}
