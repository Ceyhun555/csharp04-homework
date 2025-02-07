namespace TasksForMastering.Inheritance
{
    public class Engineer : Person
    {
        public Engineer()
        {

        }
        public Engineer(string name, int age, string field) : base(name, age)
        {
            Field = field;
        }
        public string Field { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Field: {Field}");
        }

        public void GetEngineerDetails()
        {
            base.GetInfo(); 
            Console.WriteLine($"Field: {Field}");
        }
    }





}