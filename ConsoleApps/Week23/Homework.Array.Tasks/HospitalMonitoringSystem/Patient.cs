namespace Homework.Array.Tasks.HospitalMonitoringSystem
{
    class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Temperature { get; set; }

        public Patient(string name, int age, double temperature)
        {
            Name = name;
            Age = age;
            Temperature = temperature;
        }
    }




}
