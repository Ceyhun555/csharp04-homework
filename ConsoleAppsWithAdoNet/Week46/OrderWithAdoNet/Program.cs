using OrderWithAdoNet.Models;
using System.Data;
using System.Data.SqlClient;

namespace OrderWithAdoNet
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

                    var sqlQuery = "SELECT * FROM [Order]";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //var orderID = reader["ID"];
                        //var orderCustomerID = reader["CustomerID"];
                        //var orderOrderDate = reader["OrderDate"];
                        //var orderTotalAmount = reader["TotalAmount"];
                        //var orderStatus = reader["Status"];
                        //var orderShipperID = reader["ShipperID"];

                        //Console.WriteLine($"ID:{orderID}, CustomerID:{orderCustomerID}, OrderDate:{orderOrderDate}, TotalAmount:{orderTotalAmount}, Status:{orderStatus}, ShipperID:{orderShipperID}");


                        var newOrder = new Order()
                        {
                            Id = reader.GetInt32(0),
                            CustomerID = reader.GetInt32(1),
                            OrderDate = reader.GetDateTime(2),
                            TotalAmount = reader.GetDecimal(3),
                            Status = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                            ShipperID = reader.GetInt32(5),
                        };

                        Console.WriteLine($"Map Reader Data to Order Class: ");

                        Console.WriteLine($"ID: {newOrder.Id}, CustomerID: {newOrder.CustomerID}, OrderDate: {newOrder.OrderDate}, TotalAmount: {newOrder.TotalAmount}, Status: {newOrder.Status}, ShipperID: {newOrder.ShipperID}");

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
