namespace Polymorphism.Tasks
{
    public class Electronics : Product
    {
        /// <summary>
        /// Gets or sets the warranty period in months.
        /// </summary>
        public int WarrantyPeriod { get; set; }

        /// <summary>
        /// Displays the details of an electronic product, including its warranty period.
        /// </summary>
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Warranty Period: {WarrantyPeriod} months");
        }
    }
}
