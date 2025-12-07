using ProductWithAdoNet.Models;
using System.Data.SqlClient;

namespace ProductWithAdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = ShoppingDB; Integrated Security = True; Encrypt = False";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection to database established successfully.");

                    var sqlQuery = "SELECT * FROM Product";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) 
                    {
                        //var productID = reader["ID"];
                        //var productProductName = reader["Name"];
                        //var productDescription = reader["Description"];
                        //var productPrice = reader["Price"];
                        //var productStockQuantity = reader["StockQuantity"];
                        //var productUnitsOnOrder = reader["UnitsOnOrder"];
                        //var productCategoryID = reader["CategoryID"];

                        //Console.WriteLine($"ID:{productID}, Name:{productName}, Description:{productDescription}, Price:{productPrice}, StockQuantity:{productStockQuantity}, UnitsOnOrder:{productUnitsOnOrder}, CategoryID:{productCategoryID}");


                        var newProduct = new Product()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            StockQuantity = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                            UnitsOnOrder = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                            CategoryID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6)
                        };

                        Console.WriteLine($"Map Reader Data to Order Class: ");

                        Console.WriteLine($"ID: {newProduct.Id}, Name: {newProduct.Name}, Description: {newProduct.Description}, Price: {newProduct.Price}, StockQuantity: {newProduct.StockQuantity}, UnitsOnOrder: {newProduct.UnitsOnOrder}, CategoryID: {newProduct.CategoryID} ");

                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

        }
    }
}
