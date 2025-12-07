using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWithAdoNet.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerID { get; set; } 

        public DateTime? OrderDate { get; set; }

        public decimal? TotalAmount  { get; set; }

        public string? Status { get; set; }

        public int? ShipperID {  get; set; }

        
    }
}
