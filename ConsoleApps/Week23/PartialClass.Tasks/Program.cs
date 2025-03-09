namespace PartialClass.Tasks
{
    public partial  class Program
    {
        static void Main(string[] args)
        {
            // Create a student object
            Student student = new Student(
                id: 1,
                name: "John Doe",
                dateOfBirth: new DateTime(2000, 5, 15),
                email: "Jhondoe.10@gmail.com",
                phone: "055-550-50-55",
                address: "Kazimaga Kerimov",
                major: "Computer Science",
                gpa: 3.8,
                courses: "Math 101");

            // Display student information
            Console.WriteLine("Core Information:");
            student.DisplayCoreInfo();
            Console.WriteLine();

            Console.WriteLine("Academic Information:");
            student.DisplayAcademicInfo();
            Console.WriteLine();

            Console.WriteLine("Contact Information:");
            student.DisplayContactInfo();
            Console.WriteLine();

            // Register for a new course
            Console.WriteLine("Registering for a new course.");
            student.RegisterForCourse("Science 101");
            Console.WriteLine();

            // Display updated academic info
            Console.WriteLine("Updated Academic Information:");
            student.DisplayAcademicInfo();
        }
    }


  
   




   
}
