using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer.Stocks
{
    public class IBM : Stock
    {
        public IBM(string symbol, double price) 
            : base(symbol, price)
        { }
    }
}
