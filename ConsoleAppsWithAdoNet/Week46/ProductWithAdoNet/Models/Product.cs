using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithAdoNet.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal? Price { get; set; } 

        public int? StockQuantity { get; set; }

        public int? UnitsOnOrder { get; set; }

        public int? CategoryID { get; set; } 


    }
}
