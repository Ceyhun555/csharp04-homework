namespace EncapsulationAccessModifiers
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== Employee Management System ===\n");


            Employee employee = new Employee(1, "Jhon Doe", "IT");


            Console.WriteLine("--- Intial Employe Details ---");
            employee.Getdetails();


            Console.WriteLine("--- Setting Salary ---");
            employee.SetSalary(3000);
            employee.Getdetails();



            Console.WriteLine("--- Updating Performance Rating ---");
            employee.UpdatePerformanceRating(4);
            employee.Getdetails();


            Console.WriteLine("--- Changing Department ---");
            employee.ChangeDepartment("HR");
            employee.Getdetails();


            Console.WriteLine("--- Attempting Invalid Operations ---");
            employee.SetSalary(-500);
            employee.UpdatePerformanceRating(6);
            employee.ChangeDepartment("");

            Console.WriteLine("\n--- Final Employee Details ---");
            employee.Getdetails();


        }
    }
}
