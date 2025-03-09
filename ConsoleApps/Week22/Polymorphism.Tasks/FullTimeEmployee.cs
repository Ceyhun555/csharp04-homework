namespace Polymorphism.Tasks
{
    public class FullTimeEmployee : Employee
    {
        /// <summary>
        /// Gets or sets the monthly salary for the full-time employee.
        /// </summary>
        public double MonthlySalary { get; set; }

        /// <summary>
        /// Calculates the salary for a full-time employee based on their monthly salary.
        /// </summary>
        /// <returns>The monthly salary amount.</returns>
        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }
}
