using System;
using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer.Investors
{
    public class Investor : IInvestor
    {
        public string Name { get; set; }
        public Stock Stock { get; set; }

        public Investor(string name)
        {
            Name = name;
        }

        public void Update(Stock stock)
            => Console.WriteLine($"Notified {Name} of {stock.Symbol}'s change to {stock.Price}");
    }
}
