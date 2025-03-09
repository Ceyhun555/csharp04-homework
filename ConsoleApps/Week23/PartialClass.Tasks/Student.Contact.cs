using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass.Tasks
{
    public partial class Student
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Student(int id, string name, DateTime dateOfBirth,string email, string phone, string address) :this(id, name, dateOfBirth)
        {
            Email = email;
            Phone = phone;
            Address = address;
        }

        public void DisplayContactInfo()
        {
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Address: {Address}");
        }

        partial void OnCourseRegistration()
        {
            Console.WriteLine($"Notification: You have been successfully registered for a new course.");
        }
    }
}
