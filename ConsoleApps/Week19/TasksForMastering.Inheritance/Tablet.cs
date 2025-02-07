namespace TasksForMastering.Inheritance
{
    public class Tablet : Device
    {
        public bool HasStylus { get; set; }

        public void DisplayTabletDetails()
        {
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Has Stylus: {HasStylus}");
        }

    }





}