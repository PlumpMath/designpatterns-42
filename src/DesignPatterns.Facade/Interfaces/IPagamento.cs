namespace DesignPatterns.Facade.Interfaces
{
    public interface IPagamento
    {
        bool VerificarPagamento(string numeroCartao);
        bool ProcessarPagamento(string numeroCartao, decimal valor);
    }
}
