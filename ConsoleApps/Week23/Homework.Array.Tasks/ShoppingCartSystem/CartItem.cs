namespace Homework.Array.Tasks.ShoppingCartSystem
{
    class CartItem
    {
        public string ProductName;
        public decimal Price;
        public int Quantity;

        public CartItem(string productName, decimal price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }
    }
}
