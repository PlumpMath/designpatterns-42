﻿namespace DesignPatterns.Strategy.Domain
{
    public class PedidoDeCompra
    {
        public TipoDeEntrega TipoDeEntrega { get; set; }
        public double Valor { get; set; }
        public string NomeDoProduto { get; set; }
    }

    public enum TipoDeEntrega
    {
        Correios,
        Sedex,
        MotoBoy,
        RetirarNaLoja
    }
}
