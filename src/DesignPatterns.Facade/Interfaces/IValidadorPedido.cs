namespace DesignPatterns.Facade.Interfaces
{
    public interface IValidadorPedido
    {
        bool VerificarEnderecoDeEntrega(int numeroPedido);
    }
}
