using System;
using OrderManagement.Models;
using OrderManagement.Repositories;


namespace OrderManagement.Services
{
    class CustomerService
    {
        CustomerRepository repo = new CustomerRepository();


        public void Add()
        {
            Customer c = new Customer();
            Console.Write("First Name: "); c.FirstName = Console.ReadLine();
            Console.Write("Last Name: "); c.LastName = Console.ReadLine();
            Console.Write("Email: "); c.Email = Console.ReadLine();
            Console.Write("Phone: "); c.Phone = Console.ReadLine();
            Console.Write("Address: "); c.Address = Console.ReadLine();
            Console.Write("City: "); c.City = Console.ReadLine();


            repo.Insert(c);
            Console.WriteLine("Customer Added!");
        }


        public void View()
        {
            var list = repo.GetAll();
            foreach (Customer c in list)
            {
                Console.WriteLine($"{c.Id} | {c.FirstName} {c.LastName} | {c.Email}");
            }
        }
    }




    class ProductService
    {
        ProductRepository repo = new ProductRepository();


        public void Add()
        {
            Product p = new Product();
            Console.Write("Name: "); p.ProductName = Console.ReadLine();
            Console.Write("Description: "); p.Description = Console.ReadLine();
            Console.Write("Price: "); p.Price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Stock: "); p.StockQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Units On Order: "); p.UnitsOnOrder = Convert.ToInt32(Console.ReadLine());
            Console.Write("Category ID: "); p.CategoryID = Convert.ToInt32(Console.ReadLine());


            repo.Insert(p);
            Console.WriteLine("Product Added!");
        }


        public void View()
        {
            var list = repo.GetAll();
            foreach (Product p in list)
            {
                Console.WriteLine($"{p.Id} | {p.ProductName} | {p.Price}");
            }
        }
    }




    class OrderService
    {
        OrderRepository repo = new OrderRepository();


        public void Create()
        {
            Order o = new Order();
            Console.Write("Customer ID: "); o.CustomerID = Convert.ToInt32(Console.ReadLine());
            o.OrderDate = DateTime.Now;
            o.TotalAmount = 0;
            o.Status = "Pending";


            int orderId = repo.InsertOrder(o);
            Console.WriteLine("Order Created ID=" + orderId);


            while (true)
            {
                Console.Write("Add product (y/n)? ");
                if (Console.ReadLine().ToLower() != "y") break;


                OrderDetail d = new OrderDetail();
                d.OrderID = orderId;
                Console.Write("Product ID: "); d.ProductID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qty: "); d.Quantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Unit Price: "); d.UnitPrice = Convert.ToDecimal(Console.ReadLine());


                repo.InsertOrderDetail(d);
            }
        }


        public void View()
        {
            var list = repo.GetAll();
            foreach (Order o in list)
            {
                Console.WriteLine($"{o.Id} | Customer:{o.CustomerID} | {o.Status}");
            }
        }
    }





}