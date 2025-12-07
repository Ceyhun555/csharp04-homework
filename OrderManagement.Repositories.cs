using System;
using System.Data.SqlClient;
using OrderManagement.Models;
using OrderManagement.Utils;
using System.Collections;


namespace OrderManagement.Repositories
{
    class CustomerRepository
    {
        public void Insert(Customer c)
        {
            using (SqlConnection con = new SqlConnection(Db.Conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                "INSERT INTO Customer (FirstName,LastName,Email,Phone,Address,City) VALUES (@f,@l,@e,@p,@a,@c)", con);
                cmd.Parameters.AddWithValue("@f", c.FirstName);
                cmd.Parameters.AddWithValue("@l", c.LastName);
                cmd.Parameters.AddWithValue("@e", c.Email);
                cmd.Parameters.AddWithValue("@p", c.Phone);
                cmd.Parameters.AddWithValue("@a", c.Address);
                cmd.Parameters.AddWithValue("@c", c.City);
                cmd.ExecuteNonQuery();
            }
        }


        public ArrayList GetAll()
        {
            ArrayList list = new ArrayList();


            using (SqlConnection con = new SqlConnection(Db.Conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", con);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Customer c = new Customer();
                    c.Id = (int)dr["Id"];
                    c.FirstName = dr["FirstName"].ToString();
                    c.LastName = dr["LastName"].ToString();
                    c.Email = dr["Email"].ToString();
                    c.Phone = dr["Phone"].ToString();
                    c.Address = dr["Address"].ToString();
                    c.City = dr["City"].ToString();
                    list.Add(c);
                }
            }


            return list;
        }
    }


    class ProductRepository
    {
        public void Insert(Product p)
        {
            using (SqlConnection con = new SqlConnection(Db.Conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                "INSERT INTO Product (ProductName,Description,Price,StockQuantity,UnitsOnOrder,CategoryID) VALUES (@n,@d,@p,@s,@u,@c)", con);
                cmd.Parameters.AddWithValue("@n", p.ProductName);
                cmd.Parameters.AddWithValue("@d", p.Description);
                cmd.Parameters.AddWithValue("@p", p.Price);
                cmd.Parameters.AddWithValue("@s", p.StockQuantity);
                cmd.Parameters.AddWithValue("@u", p.UnitsOnOrder);
                cmd.Parameters.AddWithValue("@c", p.CategoryID);
                cmd.ExecuteNonQuery();
            }
        }


        public ArrayList GetAll()
        {
            ArrayList list = new ArrayList();


            using (SqlConnection con = new SqlConnection(Db.Conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product", con);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Product p = new Product();
                    p.Id = (int)dr["Id"];
                    p.ProductName = dr["ProductName"].ToString();
                    p.Description = dr["Description"].ToString();
                    p.Price = Convert.ToDecimal(dr["Price"]);
                    p.StockQuantity = Convert.ToInt32(dr["StockQuantity"]);
                    p.UnitsOnOrder = Convert.ToInt32(dr["UnitsOnOrder"]);
                    p.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                    list.Add(p);
                }
            }


            return list;
        }
    }




    class OrderRepository
    {
        public int InsertOrder(Order o)
        {
            using (SqlConnection con = new SqlConnection(Db.Conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                "INSERT INTO Orders (CustomerID,OrderDate,TotalAmount,Status) OUTPUT INSERTED.Id VALUES (@c,GETDATE(),@t,@s)", con);
                cmd.Parameters.AddWithValue("@c", o.CustomerID);
                cmd.Parameters.AddWithValue("@t", o.TotalAmount);
                cmd.Parameters.AddWithValue("@s", o.Status);
                return (int)cmd.ExecuteScalar();
            }
        }


        public void InsertOrderDetail(OrderDetail d)
        {
            using (SqlConnection con = new SqlConnection(Db.Conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                "INSERT INTO OrderDetail (OrderID,ProductID,Quantity,UnitPrice) VALUES (@o,@p,@q,@u)", con);
                cmd.Parameters.AddWithValue("@o", d.OrderID);
                cmd.Parameters.AddWithValue("@p", d.ProductID);
                cmd.Parameters.AddWithValue("@q", d.Quantity);
                cmd.Parameters.AddWithValue("@u", d.UnitPrice);
                cmd.ExecuteNonQuery();
            }
        }


        public ArrayList GetAll()
        {
            ArrayList list = new ArrayList();


            using (SqlConnection con = new SqlConnection(Db.Conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Orders", con);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Order o = new Order();
                    o.Id = (int)dr["Id"];
                    o.CustomerID = (int)dr["CustomerID"];
                    o.OrderDate = Convert.ToDateTime(dr["OrderDate"]);
                    o.TotalAmount = Convert.ToDecimal(dr["TotalAmount"]);
                    o.Status = dr["Status"].ToString();
                    list.Add(o);
                }
            }


            return list;
        }
    }
}