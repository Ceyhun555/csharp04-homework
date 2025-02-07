namespace TasksForMastering.Inheritance
{
    //Task6
    public class Person
    {
        public Person()
        {

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
        public string Name { get; set; }
        public int Age { get; set; }

        
        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }





}