namespace Polymorphism.Tasks
{
    public class PartTimeEmployee : Employee
    {
        /// <summary>
        /// Gets or sets the hourly rate for the part-time employee.
        /// </summary>
        public double HourlyRate { get; set; }

        /// <summary>
        /// Gets or sets the number of hours worked by the part-time employee.
        /// </summary>
        public int HoursWorked { get; set; }

        /// <summary>
        /// Calculates the salary for a part-time employee based on hours worked and hourly rate.
        /// </summary>
        /// <returns>The calculated salary based on hours worked multiplied by hourly rate.</returns>
        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}