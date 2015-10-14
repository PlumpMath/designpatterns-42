using System;
using DesignPatterns.Facade.Interfaces;

namespace DesignPatterns.Facade.Concretas
{
    public class GerenciadorDePagamento : IPagamento
    {
        public bool VerificarPagamento(string numeroCartao)
        {
            Console.WriteLine("O pagamento foi autorizado pela empresa do cartão de número {0}", numeroCartao);

            return true;
        }

        public bool ProcessarPagamento(string numeroCartao, decimal valor)
        {
            Console.WriteLine("Pagamento de R$ {0}, realizado com sucesso.", valor);

            return true;
        }
    }
}
