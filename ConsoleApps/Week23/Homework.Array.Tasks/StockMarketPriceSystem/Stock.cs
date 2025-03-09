namespace Homework.Array.Tasks.StockMarketPriceSystem
{
    class Stock
    {
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public Stock(DateTime date, decimal price)
        {
            Date = date;
            Price = price;
        }
    }

}
