using System;
using DesignPatterns.Facade.Interfaces;

namespace DesignPatterns.Facade.Concretas
{
    public class GerenciadorDeEstoque : IEstoque
    {
        public void Update(int produtoId)
        {
            Console.WriteLine("O Produto {0} foi retirado do estoque da loja.", produtoId);
        }
    }
}
