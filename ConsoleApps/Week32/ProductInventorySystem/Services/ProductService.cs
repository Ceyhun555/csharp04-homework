using System;
using System.Collections;
using ProductInventorySystem.Constants;
using ProductInventorySystem.Models;
using ProductInventorySystem.Repositories;
using ProductInventorySystem.Utils;

namespace ProductInventorySystem.Services
{
    public class ProductService
    {
        private readonly ProductRepository _repo = new ProductRepository();

        public void AddProduct()
        {
            string code = InputHelper.ReadNonEmpty("Enter Product Code: ");
            string name = InputHelper.ReadNonEmpty("Enter Product Name: ");

            if (_repo.AddProduct(new Product { Code = code, Name = name }))
                Console.WriteLine(Messages.ProductAdded);
            else
                Console.WriteLine(Messages.ProductExists);
        }

        public void ViewAll()
        {
            if (_repo.Count == 0)
            {
                Console.WriteLine("No products to display.");
                return;
            }

            string[] sortedKeys = new string[_repo.Count];
            _repo.Keys.CopyTo(sortedKeys, 0);
            Array.Sort(sortedKeys);

            foreach (string key in sortedKeys)
                Console.WriteLine($"{key} => {_repo.GetNameByCode(key)}");
        }

        public void SearchProduct()
        {
            string code = InputHelper.ReadNonEmpty("Enter Product Code to search: ");
            string name = _repo.GetProduct(code);

            Console.WriteLine(name != null
                ? $"✅ Found: {code} => {name}"
                : Messages.ProductNotFound);
        }

        public void UpdateProduct()
        {
            string code = InputHelper.ReadNonEmpty("Enter Product Code to update: ");
            if (_repo.GetProduct(code) == null)
            {
                Console.WriteLine(Messages.ProductNotFound);
                return;
            }

            string newName = InputHelper.ReadNonEmpty("Enter New Product Name: ");
            if (_repo.UpdateProduct(code, newName))
                Console.WriteLine(Messages.ProductUpdated);
        }

        public void RemoveProduct()
        {
            string code = InputHelper.ReadNonEmpty("Enter Product Code to remove: ");
            Console.WriteLine(_repo.RemoveProduct(code)
                ? Messages.ProductRemoved
                : Messages.ProductNotFound);
        }

        public void CheckProductByName()
        {
            string name = InputHelper.ReadNonEmpty("Enter Product Name to search: ");
            Console.WriteLine(_repo.ContainsName(name)
                ? "✅ Product exists!"
                : "❌ Product not found.");
        }

        public void ShowCount()
        {
            Console.WriteLine($"Total products: {_repo.Count}");
        }
    }
}
