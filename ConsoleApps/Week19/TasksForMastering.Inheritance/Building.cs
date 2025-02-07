namespace TasksForMastering.Inheritance
{
    //Task4
    public class Building
    {
       public string BuildingType { get; set; }

        public Building(string buildingType) 
        {
            BuildingType = buildingType;
            Console.WriteLine($"Building Type: {buildingType}");
        }
    }





}