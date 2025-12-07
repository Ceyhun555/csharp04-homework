namespace IntroductionToGenericListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            List<string> countries = new List<string>();

            countries.Add("Azerbaijan");
            countries.Add("Belgium");
            countries.Add("Brazil");
            countries.Add("Germany");

            Console.WriteLine("".PadRight(20, '='));
            Console.WriteLine($"{"CountryName",-20}");
            Console.WriteLine("".PadRight(20, '-'));

            foreach (string country in countries)
            {

                Console.WriteLine($"{country,-20}");

            }
            Console.WriteLine("".PadRight(20, '='));


            Console.WriteLine($"First element: {countries[0]}");

            countries.Insert(1, "Argentina");
            Console.WriteLine($"Index of  Argentina in the list: {countries.IndexOf("Argentina")}");




            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Notebook",
                    CategoryName = "Device",
                    Description = "Lightweight laptop for professionals"
                },

                new Product()
                {
                    Id = 2,
                    Name = "iPhone 15 Pro",
                    CategoryName = "Device",
                    Description = "Latest Apple smartphone with advanced features"
                },

                new Product()
                {
                    Id = 3,
                    Name = "Nike Air Max",
                    CategoryName = "Shoose",
                    Description = "Comfortable running shoes"
                }

            };

            Console.WriteLine("".PadRight(80, '='));
            Console.WriteLine($"{"Id",-4} {"Name", -30} {"CategoryName", -10} {"Description", -36}");
            Console.WriteLine("".PadRight(80, '-'));

            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id,-4} {product.Name,-30} {product.CategoryName,-10} {product.Description,-36}");
               
            }
            Console.WriteLine("".PadRight(80, '='));



        }
    }
}
