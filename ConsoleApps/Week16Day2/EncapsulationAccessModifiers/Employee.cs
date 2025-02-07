using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAccessModifiers
{
    public class Employee
    {
        //Private Fields:
        private int _employeeId;

        private string _name;

        private string _department;

        private decimal _salary;

        private int _performanceRating;

        //Constructor.
        public Employee(int employeeId, string name, string department)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be empty.");
            }

            if (string.IsNullOrEmpty(department))
            {
                throw new ArgumentNullException("Department cannot be empty.");
            }

            this._employeeId = employeeId;
            this._name = name;
            this._department = department;
            this._salary = 0;
            this._performanceRating = 0;
        }

        // SetSalary method to set salary, ensuring it's positive.
        public void SetSalary(decimal salary)
        {
            if (salary > 0)
            {
                this._salary = salary;
                Console.WriteLine($"Salary updated successfully.");
            }
            else
            {
                Console.WriteLine("Error: Salary must be positive.");
            }
        }


        // GetDetails method to display all employee details.
        public void Getdetails()
        {
            Console.WriteLine($"Employee ID: {_employeeId}");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Department: {_department}");
            Console.WriteLine($"Salary: {_salary:F2}");
            Console.WriteLine($"Performance Rating: {_performanceRating}");
            Console.WriteLine();
        }


        // UpdatePerformanceRating method to ensure rating is between 1 and 5.
        public void UpdatePerformanceRating(int rating)
        {
            if (rating >= 1 && rating <= 5)
            {
                this._performanceRating = rating;
                Console.WriteLine("Performance rating updated successfully ");
            }
            else
            {
                Console.WriteLine("Error: Performance rating must be between 1 and 5.");
            }
        }

        // ChangeDepartment method to change department, ensuring the new department is not empty.
        public void ChangeDepartment(string newDepartment)
        {
            if (!string.IsNullOrEmpty(newDepartment))
            {
               this._department = newDepartment;
                Console.WriteLine("Department updated successfully.");
            }
            else
            {
                Console.WriteLine("Error: Department name cannot be empty.");
            }
        }
    }

}


