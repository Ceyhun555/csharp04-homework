using ConsoleApp1.Models;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
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

                    var sqlQuery = "SELECT * FROM Customer";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var customerID = reader["ID"];
                        var customerFirstName = reader["FirstName"];
                        var customerLastName = reader["LastName"];
                        var customerEmail = reader["Email"];
                        var customerPhone = reader["Phone"];
                        var customerAddress = reader["Address"];
                        var customerCity = reader["City"];

                        Console.WriteLine($"ID:{customerID}, FirstName:{customerFirstName}, LastName:{customerLastName}, Email:{customerEmail}, Phone:{customerPhone}, Address:{customerAddress}, City:{customerCity}");


                        var newCustomer = new Customer()
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Email = reader.GetString(3),
                            Phone = reader.GetString(4),
                            Address = reader.GetString(5),
                            City = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),

                        };

                        Console.WriteLine($"Map Reader Data to Customer Class: ");

                        Console.WriteLine($"ID: {newCustomer.Id}, FirstName: {newCustomer.FirstName}, LastName: {newCustomer.LastName}, Email: {newCustomer.Email}, Phone: {newCustomer.Phone}, Address: {newCustomer.Address}, City: {newCustomer.City}");

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
