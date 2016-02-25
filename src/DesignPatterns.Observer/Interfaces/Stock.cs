using System.Collections.Generic;

namespace DesignPatterns.Observer.Interfaces
{
    public abstract class Stock
    {
        private string _symbol;
        private double _price;

        public string Symbol
        {
            get { return _symbol; }
            set
            {
                _symbol = value;
                Notify();
            }
        }

        private void Notify()
        {
            foreach (var investor in Investors)
                investor.Update(this);
        }

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                Notify();
            }
        }

        private static IList<IInvestor> Investors { get; set; }

        protected Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;

            if (Investors == null)
                Investors = new List<IInvestor>();
        }

        public void Attach(IInvestor investor)
        {
            if (!Investors.Contains(investor))
                Investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            if (Investors.Contains(investor))
                Investors.Remove(investor);
        }
    }
}
