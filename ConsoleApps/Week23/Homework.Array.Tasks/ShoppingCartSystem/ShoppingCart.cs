namespace Homework.Array.Tasks.ShoppingCartSystem
{
    class ShoppingCart
    {
        private CartItem[] items;
        private int count;
        private int capacity;

        public ShoppingCart(int size)
        {
            capacity = size;
            items = new CartItem[capacity];
            count = 0;
        }

        public bool AddItem(string productName, decimal price, int quantity)
        {
            if (count >= capacity)
            {
                return false;
            }

            items[count] = new CartItem(productName, price, quantity);
            count++;
            return true;
        }

        public bool RemoveItem(string productName)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].ProductName == productName)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    items[count - 1] = null;
                    count--;
                    return true;
                }
            }
            return false;
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            for (int i = 0; i < count; i++)
            {
                total += items[i].Price * items[i].Quantity;
            }
            return total;
        }

        public void DisplayCart()
        {
            Console.WriteLine("Shopping Cart:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{items[i].ProductName} - ${items[i].Price} x {items[i].Quantity}");
            }
            Console.WriteLine($"Total Price: ${CalculateTotal()}");
        }
    }
}
