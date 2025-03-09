namespace Homework.Array.Tasks.StockMarketPriceSystem
{
    class StockMarketTracker
    {
        private Stock[] stocks;
        private int count;

        public StockMarketTracker(int size)
        {
            stocks = new Stock[size];
            count = 0;
        }

        public void AddStock(DateTime date, decimal price)
        {
            if (count < stocks.Length)
            {
                stocks[count++] = new Stock(date, price);
            }
        }

        public Stock FindHighestPrice()
        {
            if (count == 0)
            {
                return null;
            }

            Stock highest = stocks[0];
            for (int i = 1; i < count; i++)
            {
                if (stocks[i].Price > highest.Price)
                {
                    highest = stocks[i];
                }
            }
            return highest;
        }

        public Stock FindLowestPrice()
        {
            if (count == 0)
            {
                return null;
            }

            Stock lowest = stocks[0];
            for (int i = 1; i < count; i++)
            {
                if (stocks[i].Price < lowest.Price)
                {
                    lowest = stocks[i];
                }
            }
            return lowest;
        }

        public decimal CalculateAveragePrice()
        {
            if (count == 0)
            {
                return 0;
            }

            decimal sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += stocks[i].Price;
            }
            return sum / count;
        }

        public void SortByDate()
        {
            for (int i = 0; i < stocks.Length - 1; i++)
            {
                for (int j = i + 1; j < stocks.Length; j++)
                {
                    if (stocks[i].Date > stocks[j].Date)
                    {
                        Stock temp = stocks[i];
                        stocks[i] = stocks[j];
                        stocks[j] = temp;
                    }
                }
            }
        }

        public void DisplayStocks()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Date: {stocks[i].Date}, Price: {stocks[i].Price}");
            }
        }
    }
}