namespace Polymorphism.Tasks
{
    //Task2
    public abstract class Employee
    {
        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Calculates the salary for the employee.
        /// This is a virtual method that can be overridden by derived classes.
        /// </summary>
        /// <returns>The calculated salary amount.</returns>
        public virtual double CalculateSalary()
        {
            return 0;
        }
    }
}
