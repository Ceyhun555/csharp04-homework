using OrderDetailWithAdoNet.Models;
using System.Data.SqlClient;

namespace OrderDetailWithAdoNet
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

                    var sqlQuery = "SELECT * FROM OrderDetail";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        //var orderDetailID = reader["ID"];
                        //var orderDetailOrderID = reader["OrderID"];
                        //var orderDetailProductID = reader["ProductID"];
                        //var orderDetailQuantity = reader["Quantity"];
                        //var orderDetailUnitPrice = reader["UnitPrice"];

                        //Console.WriteLine($"ID:{orderDetailID}, OrderID:{orderDetailOrderID}, ProductID:{orderDetailProductID}, Quantity:{orderDetailQuantity}, UnitPrice:{orderDetailUnitPrice}");



                        var newOrderDetail = new OrderDetail()
                        {
                            Id = reader.GetInt32(0),
                            OrderID = reader.GetInt32(1),
                            ProductID = reader.GetInt32(2),
                            Quantity = reader.GetInt32(3),
                            UnitPrice = reader.GetDecimal(4),
                        };

                        Console.WriteLine($"Map Reader Data to Order Class: ");

                        Console.WriteLine($"ID: {newOrderDetail.Id}, OrderID: {newOrderDetail.OrderID}, ProductID: {newOrderDetail.ProductID}, Quantity: {newOrderDetail.Quantity}, UnitPrice: {newOrderDetail.UnitPrice}");


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
