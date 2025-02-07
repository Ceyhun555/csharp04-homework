using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOP.Class
{
    internal class Student
    {
        /*Default Constructor:
            Initializes the Name to "Unknown", Grade to 0, Age to 18, and Major to "Undeclared".
        Parameterized Constructor 1:
        Accepts Name and Age as parameters and sets default values for the other properties.
        Parameterized Constructor 2:
        Accepts Name, Age, Grade, and Major as parameters.*/
        public Student(string name = "Unknown", int grade = 0, int age = 18, string major = "Undeclared")
        {
            Name = name;
            Grade = grade;
            Age = age;
            Major = major;
            
        }

        public Student (string name, int age)
        {
            Name = name;
            Age = age;
            Grade = 0;
            Major = "Undeclared";
        }

        public Student (string name, string major, int age, int grade )
        {
            Name = name;
            Age = age;
            Major = major;
            Grade = grade;
        }


        


        /// <summary>
        /// Name: The name of the student.
        /// Type: string
        /// Default: "Unknown"
        ///Validation: Must not be empty or null.
        /// </summary>
        public string Name { get; set; } 



        private int _grade; // field

        /// <summary>
        /// Grade: The student's grade (0–100).
        ///Type: int
        ///Default: 0
        ///Validation: Must be between 0 and 100
        /// </summary>
        public int Grade // property
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Grade must be between 0 - 100: ");

                }
                else
                {
                    _grade = value;
                    Console.WriteLine($"Your Grade:   {_grade} ");
                }

            }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                    Console.WriteLine("Age must be > 0. ");
                }
            }

        }

        private string _major;

        public string Major
        {
            get
            {
                return _major;
            }
            set
            {
                _major = value;
            }
        }
    }
}

                }
                else
                {