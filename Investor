using System.Collections.Generic;
using System.Linq;

namespace StockMarket
{
    public class Investor
    {
        private readonly Dictionary<string, Stock> _portfolio = new Dictionary<string, Stock>();
        private string _fullName { get; set; }
        private string _emailAdress { get; set; }
        private decimal _moneyToInvest { get; set; }
        private string _brokerName { get; set; }
        public Investor(string fullName, string emailAdress, decimal moneyToInvest, string brokerName)
        {
            _fullName = fullName;
            _emailAdress = emailAdress;
            _moneyToInvest = moneyToInvest;
            _brokerName = brokerName;
        }
        private decimal GetMaxValue()
        {
            decimal maxValue = _portfolio.First().Value.MarketCapitalization;
            foreach (var item in _portfolio.Values)
            {
                if (maxValue < item.MarketCapitalization)
                {
                    maxValue = item.MarketCapitalization;
                }
            }
            return maxValue;
        }
        public int Count()
        {
            return _portfolio.Count;
        }
        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && _moneyToInvest - stock.PricePerShare >= 0)
            {
                _portfolio.Add(stock.CompanyName, stock);
                _moneyToInvest -= stock.PricePerShare;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            if (!_portfolio.TryGetValue(companyName, out Stock current)) return $"{companyName} does not exist.";
            if (sellPrice < current.PricePerShare) return $"Cannot sell {companyName}.";
            _portfolio.Remove(companyName);
            _moneyToInvest += sellPrice;
            return $"{companyName} was sold.";
        }
        public Stock FindStock(string companyName)
        {
            _portfolio.TryGetValue(companyName, out Stock current);
            return current;
        }
        public Stock FindBiggestCompany()
        {
            return _portfolio.FirstOrDefault(a => a.Value.MarketCapitalization == GetMaxValue()).Value;
        }
        public string InvestorInformation()
        {
            string info = $"The investor {_fullName} with a broker {_brokerName} has stocks:";
            foreach (var item in _portfolio.Values)
            {
                info += $"\n{item}";
            }
            return info;
        }
    }
}
