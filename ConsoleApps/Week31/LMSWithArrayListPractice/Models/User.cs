using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSWithArrayListPractice.Models
{
    public class User
    {
        public string Username { get; private set; }

        private string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public bool ValidatePassword(string inputPassword)
        {
            return Password == inputPassword;
        }
    }
}
