﻿using System;

namespace PhoneBookSystem.Models
{
    public class Contact
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime LastModified { get; set; }
    }
}

