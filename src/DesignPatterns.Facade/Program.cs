using System;
using DesignPatterns.Facade.Concretas;
using DesignPatterns.Facade.Interfaces;

namespace DesignPatterns.Facade
{
    class Program
    {
        static void Main(string[] arg)
        {
            SemFacade();
            ComFacade();
            Console.ReadKey();
        }

        static void SemFacade()
        {
            IEstoque gerenciadorDeEstoque = new GerenciadorDeEstoque();
            gerenciadorDeEstoque.Update(1);

            IValidadorPedido gerenciadorDeValidacaoPedido = new GerenciadorDeValidacaoPedido();
            gerenciadorDeValidacaoPedido.VerificarEnderecoDeEntrega(22);

            IPagamento gerenciadorDePagamento = new GerenciadorDePagamento();
            gerenciadorDePagamento.VerificarPagamento("0000001");
            gerenciadorDePagamento.ProcessarPagamento("0000001", 113);
        }

        static void ComFacade()
        {
            //TODO: Usar injetor de dependência.
            var lojaOnline = new LojaOnlineFacade(new GerenciadorDeEstoque(), new GerenciadorDeValidacaoPedido(), new GerenciadorDePagamento());
            lojaOnline.ComprarProduto(1, 22);
        }
    }
}
