using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class BookCheckOutRecord
    {
        public int Id { get; set; }

        public int BookId   { get; set; }

        public int MemberId { get; set; }

        public DateTime CheckOutDate { get; set; }

        public DateTime? ReturnDate { get; set; }


    }
}
