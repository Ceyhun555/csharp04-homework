namespace Polymorphism.Tasks
{
    public class Food : Product
    {
        /// <summary>
        /// Gets or sets the expiration date of the food product.
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Displays the details of a food product, including its expiration date.
        /// </summary>
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Expiration Date: {ExpirationDate.ToShortDateString()}");
        }
    }
}
