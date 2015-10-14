using System;
using DesignPatterns.Facade.Interfaces;

namespace DesignPatterns.Facade.Concretas
{
    public class GerenciadorDeValidacaoPedido : IValidadorPedido
    {
        public bool VerificarEnderecoDeEntrega(int numeroPedido)
        {
            Console.WriteLine("O produto com o pedido número {0} pode ser enviado.", numeroPedido);

            return true;
        }
    }
}
