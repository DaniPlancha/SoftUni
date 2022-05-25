namespace StockMarket
{
    public class Stock
    {
        public string CompanyName { get; }
        public string Director { get; }
        public decimal PricePerShare { get; }
        public int TotalNumberOfShares { get; }
        public decimal MarketCapitalization { get; }
        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumberOfShares = totalNumberOfShares;
            MarketCapitalization = pricePerShare * totalNumberOfShares;
        }
        public override string ToString()
        {
            return $"Company: {CompanyName}\nDirector: { Director}\nPrice per share: ${ PricePerShare}\nMarket capitalization: ${ MarketCapitalization}";
        }
    }
}
