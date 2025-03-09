namespace Homework.Array.Tasks.StoreInventoryManagement
{
    class StoreInventory
    {
        private Product[] products;
        private int count;

        public StoreInventory(int size)
        {
            products = new Product[size];
            count = 0;
        }

        public void AddProduct(string name, decimal price)
        {
            if (count < products.Length)
            {
                products[count++] = new Product(name, price);
            }
        }

        public Product FindMostExpensive()
        {
            if (count == 0)
            {
                return null;
            }
            Product maxProduct = products[0];
            for (int i = 0; i < count; i++)
            {
                if (products[i].Price > maxProduct.Price)
                {
                    maxProduct = products[i];
                }
            }
            return maxProduct;
        }

        public Product FindCheapest()
        {
            if (count == 0)
            {
                return null;
            }

            Product minProduct = products[0];
            for (int i = 0; i < count; i++)
            {
                if (products[i].Price < minProduct.Price)
                {
                    minProduct = products[i];
                }
            }
            return minProduct;
        }

        public void SortByPrice()
        {
            for (int i = 0; i < products.Length - 1; i++)
            {
                for (int j = i + 1; j < products.Length; j++)
                {
                    if (products[i].Price > products[j].Price)
                    {
                        Product temp = products[i];
                        products[i] = products[j];
                        products[j] = temp;
                    }
                }
            }
        }

        public Product SearchByName(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (products[i].Name == name)
                {
                    return products[i];
                }
            }
            return null;
        }

        public void DisplayProducts()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Name: {products[i].Name}, Price: {products[i].Price}");
            }
        }
    }
}
