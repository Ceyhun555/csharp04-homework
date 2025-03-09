using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass.Tasks
{
    public partial class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student(int id, string name, DateTime dateOfBirth)
        {
            ID = id;
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public void DisplayCoreInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        }
    }
}
