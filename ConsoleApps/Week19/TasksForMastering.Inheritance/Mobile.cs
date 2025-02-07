namespace TasksForMastering.Inheritance
{
    public class Mobile : Device
    {
        public string Model { get; set; }

        public void Displaydetails()
        {
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Model: {Model}");
        }
    }





}