using LMSWithArrayListPractice.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSWithArrayListPractice.Managers
{
    public class AuthenticationManager
    {
        
        private readonly ArrayList  _users;

        private const int MaxLoginAttempts = 3;

        private User? _loggedInUser = null;

        public AuthenticationManager()
        { 
            _users = new ArrayList();
            
            var user1 = new User(username: "admin", password: "admin1234@");
            var user2 = new User(username: "moderator", password: "moderator1234@");
         
            AddUser(user1);
            AddUser(user2);
        }

        public bool AddUser(User user)
        {
            if(user == null)
            {
                Console.WriteLine("User cannot be null!");
                return false;
            }

            if (string.IsNullOrEmpty(user.Username))
            {
                Console.WriteLine("Username cannot be empty!");
            }

            var isUsernameExists = IsUsernameExists(user.Username);

            if (isUsernameExists == true)
            {
                Console.WriteLine("Username already exists");
            }

            _users.Add(user);
            return true;
        }

        private bool IsUsernameExists(string username)
        {
            foreach (User user in _users)
            {
                if (username == user.Username)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Login()
        {
   
            int attemptCount = 0;

            while (attemptCount < MaxLoginAttempts)
            {

                string username = GetValidatedInput(
                    prompt: "Enter username:",
                    errorMessage: "Username cannot be empty.Please try again.");

                string password = GetValidatedInput(
                    prompt: "Enter password:",
                    errorMessage: "Password cannot be empty.Please try again.",
                    maskInput: true);


                foreach(User user in _users)
                {
                    if(username == user.Username && user.ValidatePassword(password))
                    {
                        _loggedInUser = user;
                        Console.WriteLine($"Welcome, {username}");
                        return true;
                    }
                }

                attemptCount++;
                Console.WriteLine($"Invalid credentials. Please try again. You have {MaxLoginAttempts - attemptCount} attempts remaining.");
            }

            Console.WriteLine("Maximum login attempts exceeded. Access denied.");
            return false;
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {
                Console.WriteLine("goodbye");
                _loggedInUser = null;
            }
            else
            {
                Console.WriteLine("No user is currently logged in.");
            }
        }

        public bool IsLoggedIn()
        {
            return _loggedInUser != null;
        }

       
        private string GetValidatedInput(string prompt, string errorMessage, bool maskInput = false)
        {
            
            string input;

            do
            {              
                Console.WriteLine(prompt);
                input = maskInput ? ReadPassword() : Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(errorMessage);
                }
            } while (string.IsNullOrWhiteSpace(input)); 

            return input;
        }

        private string ReadPassword()
        {
            string password = string.Empty;
            ConsoleKey key;

            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Substring(0, password.Length - 1);
                    Console.Write("\b \b");
                }

                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    password += keyInfo.KeyChar;
                    Console.Write("*");
                }

            } while (key != ConsoleKey.Enter); 

            Console.WriteLine();
            return password;
        }
    }
}
