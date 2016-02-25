using DesignPatterns.Observer.Investors;
using DesignPatterns.Observer.Stocks;

namespace DesignPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var ibmStock = new IBM("$", 1000);
            var investor = new Investor("Pedro Benevides");
            var investor2 = new Investor("Myrelle Coura");
            
            ibmStock.Attach(investor);
            ibmStock.Attach(investor2);
            ibmStock.Attach(investor2);

            ibmStock.Price = 1500;
        }
    }
}
