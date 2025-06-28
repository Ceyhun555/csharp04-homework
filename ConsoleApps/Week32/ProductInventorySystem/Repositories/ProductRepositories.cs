using System.Collections;
using ProductInventorySystem.Models;

namespace ProductInventorySystem.Repositories
{
    public class ProductRepository
    {
        private Hashtable _products = new Hashtable();

        public bool AddProduct(Product product)
        {
            if (_products.ContainsKey(product.Code))
                return false;

            _products.Add(product.Code, product.Name);
            return true;
        }

        public string GetProduct(string code)
        {
            return _products.ContainsKey(code) ? (string)_products[code] : null;
        }

        public bool UpdateProduct(string code, string newName)
        {
            if (!_products.ContainsKey(code))
                return false;

            _products[code] = newName;
            return true;
        }

        public bool RemoveProduct(string code)
        {
            if (!_products.ContainsKey(code))
                return false;

            _products.Remove(code);
            return true;
        }

        public bool ContainsName(string name)
        {
            return _products.ContainsValue(name);
        }

        public ICollection Keys => _products.Keys;

        public string GetNameByCode(string code) => (string)_products[code];

        public int Count => _products.Count;
    }
}
