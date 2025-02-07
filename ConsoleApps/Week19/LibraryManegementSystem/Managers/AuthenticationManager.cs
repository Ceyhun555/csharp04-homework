using LibraryManegementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManegementSystem.Managers
{
    public class AuthenticationManager
    {
        private readonly User[] _users;
        private int _userCount;
        private const int MaxUsers = 10;
        private const int MaxloginAttempts = 3;
        private User? LoggedInUser = null;

        public AuthenticationManager()
        {
            _users = new User[MaxUsers];
            
            _userCount = 0;

            var user1 = new User(username: "admin", password: "admin1234@");
            var user2 = new User(username: "moderator", password: "moderator1234@");

            

            AddUser(user1);
            AddUser(user2);
        }

        public bool AddUser(User user)
        {
            if (_userCount >= MaxUsers)
            {
                Console.WriteLine($"User limit reached. {_userCount}/{MaxUsers} users are already registered.");
                return false;
            }

            _users[_userCount++] = user;    
            return true;
        }


        public bool Login()
        {
            int attemptCount = 0;

            while (attemptCount < MaxloginAttempts) 

            {
                //admin
                string username = GetValidatedInput(prompt: "Enter username", errorMesaage: "username cannot be empty.Please try again. ");

                //*******
                string password = GetValidatedInput(prompt: "Enter password", errorMesaage: "password cannot be empty.Please try again. ", maskInput: true);


                for (int i = 0; i < _userCount; i++)
                {
                    if (username == _users[i].Username && _users[i].ValidatePassword(password))
                    {
                        LoggedInUser = _users[i];

                        Console.WriteLine($"Welcome, {username}");

                        return true;
                    }
                }

                attemptCount++;
                Console.WriteLine($"Invalid credentials. Please try again.You have {MaxloginAttempts - attemptCount} attempt remaining.");
            }

            Console.WriteLine("Maximum Login attempts exceeded.Access denied.");
            return false;
        }

        public void Logout()
        {
            if(IsloggenIn())
            {
                Console.WriteLine("Goodbye");
                LoggedInUser = null;
            }
            else
            {
                Console.WriteLine("No user is currently logged in. ");
            }
                
        }

        public bool IsloggenIn()
        {
            return LoggedInUser != null;   
        }

        private string GetValidatedInput(string prompt, string errorMesaage, bool maskInput = false)
        {
            string input;

            do
            {
                Console.WriteLine(prompt);
                input = maskInput ? ReadPassword() : Console.ReadLine(); //ternary operator


                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(errorMesaage);
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

                if (key == ConsoleKey.Backspace && password.Length > 0 )
                {
                    password = password.Substring(0, password.Length - 1);
                    Console.Write("\b \b");

                }else if (!char.IsControl(keyInfo.KeyChar))
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
