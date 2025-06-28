using System;
using StudentGradesSystem.Services;

namespace StudentGradesSystem
{
    class Program
    {
        static void Main()
        {
            StudentService service = new StudentService();
            int choice;

            do
            {
                Console.WriteLine("\n===== Student Grade System =====");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Show all students");
                Console.WriteLine("3. Show average grade");
                Console.WriteLine("4. Remove student by name");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("❌ Invalid choice.");
                    continue;
                }

                Console.WriteLine();
                switch (choice)
                {
                    case 1: service.AddStudent(); break;
                    case 2: service.ShowAllStudents(); break;
                    case 3: service.ShowAverageGrade(); break;
                    case 4: service.RemoveStudentByName(); break;
                    case 5: Console.WriteLine("Exiting..."); break;
                    default: Console.WriteLine("Invalid choice."); break;
                }

            } while (choice != 5);
        }
    }
}
