using DesignPatterns.Facade.Interfaces;

namespace DesignPatterns.Facade
{
    public class LojaOnlineFacade
    {
        private readonly IEstoque gerenciadorDeEstoque;
        private readonly IValidadorPedido gerenciadorDePedido;
        private readonly IPagamento gerenciadorDePagamento;

        public LojaOnlineFacade(IEstoque gerenciadorDeEstoque, IValidadorPedido gerenciadorDePedido, IPagamento gerenciadorDePagamento)
        {
            this.gerenciadorDeEstoque = gerenciadorDeEstoque;
            this.gerenciadorDePedido = gerenciadorDePedido;
            this.gerenciadorDePagamento = gerenciadorDePagamento;
        }

        public void ComprarProduto(int codigoDoProduto, int numeroDoPedido)
        {
            gerenciadorDeEstoque.Update(codigoDoProduto);
            gerenciadorDePedido.VerificarEnderecoDeEntrega(numeroDoPedido);

            if (gerenciadorDePagamento.VerificarPagamento("0000001"))
                gerenciadorDePagamento.ProcessarPagamento("0000001", 113);
        }
    }
}
