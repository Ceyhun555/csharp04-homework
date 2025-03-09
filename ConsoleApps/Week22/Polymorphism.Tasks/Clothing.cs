namespace Polymorphism.Tasks
{
    public class Clothing : Product
    {
        /// <summary>
        /// Gets or sets the size of the clothing item.
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// Displays the details of a clothing item, including its size.
        /// </summary>
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Size: {Size}");
        }
    }
}
