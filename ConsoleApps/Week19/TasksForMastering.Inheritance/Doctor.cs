namespace TasksForMastering.Inheritance
{
    public class Doctor : Person
    {
        public Doctor ()
        {

        }
        public Doctor(string name, int age, string specialty) : base(name, age)
        {
            Specialty = specialty;
        }
        public string Specialty { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Specialty: {Specialty}"); 
        }
        public void GetDoctorDetails()
        {

            base.GetInfo(); 

            Console.WriteLine($"Specialty: {Specialty}");
        }
    }





}