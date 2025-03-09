namespace Polymorphism.Tasks
{
    //Task4
    public abstract class Product
    {
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Displays the basic details of the product.
        /// This method can be overridden by derived classes to show additional information.
        /// </summary>
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price}");
        }
    }
}
