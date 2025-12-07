using Practice.Enums;
using Practice.Models;
using Practice.Services;
using System.Runtime.CompilerServices;

namespace Practice
{
    internal class Program
    {
        private const string ConnectionString =
            "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = PracticeDB; Integrated Security = True; Encrypt = False";

        private static readonly DatabaseManager _dbManager = new(ConnectionString);

       


        static void Main(string[] args)
        {
            try
            {
                RunApplication();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Application error: {ex.Message}");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        private static void RunApplication()
        {
            bool countinueRunning = true;

            while (countinueRunning)
            {
                DisplayMenu();
                countinueRunning = ProcessMenuChoice();

                if (countinueRunning)
                {
                    WaitForKeyPress();
                }

            }
        }


        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║  Student Management System   ║");
            Console.WriteLine("╠══════════════════════════════╣");
            Console.WriteLine("║  1. Create Student           ║");
            Console.WriteLine("║  2. View All Students        ║");
            Console.WriteLine("║  3. Update Student           ║");
            Console.WriteLine("║  4. Delete Student           ║");
            Console.WriteLine("║  5. Exit                     ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.Write("\nSelect an option (1-5): ");
        }

        private static bool ProcessMenuChoice()
        {
            return Enum.TryParse(Console.ReadLine(), out MenuOption choice)
                ? HandleMenuOption(choice)
                : HandleInvalidInput();
        }



        private static bool HandleMenuOption(MenuOption choice)
        {
            switch (choice)
            {
                case MenuOption.Create:
                    CreateStudent();
                    return true;

                case MenuOption.ViewAll:
                    ViewAllStudents();
                    return true;

                case MenuOption.Update:
                    UpdateStudent();
                    return true;

                case MenuOption.Delete:
                    DeleteStudent();
                    return true;

                case MenuOption.Exit:
                    Console.WriteLine("Thank you for using the system!");
                    return false;

                default:
                    // Should never hit default due to enum parsing, but keep it defensive.
                    return HandleInvalidInput();
            }
        }

        private static int? GetValidStudentId(string prompt)
        {
            Console.Write(prompt);
            return int.TryParse(Console.ReadLine(), out int id) ? id : (int?)null;
        }



        private static Student GetStudentDetails(int? id = null)
        {
            Console.Write("FirstName: ");
            var firstName= Console.ReadLine()?.Trim();

            Console.Write("LastName: ");
            var lastName = Console.ReadLine()?.Trim();

            Console.Write("Age: ");
            var age = Console.ReadLine()?.Trim();

            Console.Write("Grade: ");
            var grade = Console.ReadLine()?.Trim();



            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("FirstName and LastName are required.");
            }
            //Age validation: age - ola bilmez, age 0 ola bilmez, age <7 ola bilmez, age >20 ola bilmez
            //grade validation: 

            return new Student
            {
                Id = id ?? 0,  // For Create we don’t use Id; for Update we pass the existing Id.
                FirstName = firstName,
                LastName = lastName,
                Age = 24,
                Grade = 50   //try parse edib validate edecem sonra set edecem
            };

        }



        private static void CreateStudent()
        {
            try
            {
                Console.WriteLine("\nCreate New Student");
                var student = GetStudentDetails();
                var id = _dbManager.CreateStudent(student);
                Console.WriteLine($"Student created succesfully with ID: {id}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error creating student: {ex.Message}");
            }
        }

        private static void ViewAllStudents()
        {
            try
            {
                var students = _dbManager.GetAllStudents();
                DisplayStudents(students);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving students: {ex.Message}");
            }
        }

        private static void DisplayStudents(IEnumerable<Student> students)
        {
            if (!students.Any())
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\nStudent List:");
            Console.WriteLine("".PadRight(100, '='));
            Console.WriteLine($"{"ID",-4} {"FirstName",-20} {"LastName",-30} {"Age",-45} {"Grade",-55}");
            Console.WriteLine("".PadRight(100, '-'));

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id,-4} {student.FirstName,-20} {student.LastName,-30} {student.Age,-45} {student.Grade,-55} {student.CreatedAt,-20:g}");
            }

            Console.WriteLine("".PadRight(100, '-'));
        }



        private static void UpdateStudent()
        {
            try
            {
                var id = GetValidStudentId("\nEnter student ID to update: ");
                if (!id.HasValue)
                {
                    Console.WriteLine("Invalid ID provided.");
                    return;

                }
                    var student = GetStudentDetails(id.Value);  
                    var success = _dbManager.UpdateStudent(student);
                    Console.WriteLine(success
                    ? "Student updated successfully!"
                    : "Update failed. Student not found.");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating student: {ex.Message}");
            }
        }




        private static void DeleteStudent()
        {
            try
            {
                var id = GetValidStudentId("\nEnter student ID to delete: ");
                if (!id.HasValue) 
                {
                    Console.WriteLine("Invalid ID provided. ");
                    return;
                }

                Console.Write($"Are you sure you want to delete student {id}? (y/n): ");
                if(Console.ReadLine()?.Trim().ToLower() != "y")
                {
                    Console.WriteLine("Delete cancelled. ");
                    return;
                }


                var success = _dbManager.DeleteStudent(id.Value);

                Console.WriteLine(success
                    ? "Student deleted successfully!"
                    : "Delete failed. Student not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting student: {ex.Message}");
            }
        }



        private static bool HandleInvalidInput()
        {
            Console.WriteLine("Invalid option! Please enter a number between 1 and 5.");
            WaitForKeyPress();
            return true;
        }


        private static void WaitForKeyPress()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }

    }
}
