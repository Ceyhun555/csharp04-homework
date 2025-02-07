namespace TasksForMastering.Inheritance
{
    public class Apartment : Building
    {
        public int NumberOfFloors { get; set; }
        public Apartment(string buildingType, int numberOfFloors) : base(buildingType) 
        {
           NumberOfFloors = numberOfFloors;
            Console.WriteLine($"Number of Floors: {numberOfFloors}");
        }
    }





}