using System.Collections;
using System.ComponentModel;

namespace StudentGradesManagement
{
    internal class Program
    {
        static ArrayList students = new ArrayList();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Student Grade Sytem =====");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Show all student");
                Console.WriteLine("3. Show average grade");
                Console.WriteLine("4. Remove student by name");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ShowStudent();
                        break;
                    case "3":
                        ShowAverageGrade();
                        break;
                    case "4":
                        RemoveStudent();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. try again.");
                        break;
                }

            }


        }

        private static void AddStudent()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty.");
                return;
            }


            foreach (object obj in students) 
            {
                if(obj is Student students && students.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Student with this name already exists.");
                    return;
                }
            }

            Console.Write("Enter grade: ");
            if(!double.TryParse(Console.ReadLine(), out double grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade. Must be between 0 and 100.");
                return;
            }

            students.Add(new Student(name, grade));
            Console.WriteLine("Student added!");
        }

        private static void ShowStudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students to display.");
                return;
            }

            students.Sort(new GradeComparer());
            Console.WriteLine("Students(sorted by grade): ");

            foreach (object obj in students)
            {
                if(obj is Student students)
                {
                    Console.WriteLine($"Name: {students.Name} | Grade: {students.Grade}");
                }
            }
        }

        private static void ShowAverageGrade()
        {
            if (students.Count == 0) 
            {
                Console.WriteLine("No students to calculate average.");
                return;
            }

            double total = 0;
            int count = 0;

            foreach (object obj in students)
            { 
                if( obj is Student students)
                {
                    total += students.Grade;
                    count++;
                }
            }
            Console.WriteLine($" Average grade: {total/count}");
        }

        private static void RemoveStudent()
        {
            Console.Write("Enter name to remove: ");
            string name = Console.ReadLine().Trim();

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i] is Student student && student.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    students.RemoveAt(i);
                    Console.WriteLine($"Student '{name}' removed from list.");
                    return;
                }
            }

            Console.WriteLine($"Student '{name}' not found.");
        }


    }
}
