using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass.Tasks
{
    public partial class Student
    {
        public string Major { get; set; }
        public double GPA { get; set; }
        public string Courses { get; set; }

        public Student(int id, string name, DateTime dateOfBirth, string email, string phone, string address,string major, double gpa, string courses):this(id, name, dateOfBirth, email, phone, address)
        {
            Major = major;
            GPA = gpa;
            Courses = courses;
        }

        public void DisplayAcademicInfo()
        {
            Console.WriteLine($"Major: {Major}");
            Console.WriteLine($"GPA: {GPA}");
            Console.WriteLine($"Courses: {Courses}");
        }

        partial void OnCourseRegistration();

        public void RegisterForCourse(string course)
        {
            
            OnCourseRegistration();
        }
    }
}
