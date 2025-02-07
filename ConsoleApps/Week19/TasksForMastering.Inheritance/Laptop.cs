namespace TasksForMastering.Inheritance
{
    public class Laptop
    {
        private Screen screen = new Screen(); 

        public void DisplayLaptopResolution()
        {
            Console.Write("Laptop ");
            screen.ShowResolution(); 
        }
    }





}