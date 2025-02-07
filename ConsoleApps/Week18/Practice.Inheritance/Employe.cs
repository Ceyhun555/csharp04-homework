namespace Practice.Inheritance
{
    class Employe : Person
    {
        public string Position { get; set; }

        public decimal Salary { get; set; }

        public void GetDetails ()
        {
            Console.WriteLine($"Name: {this.Name}, Surname: {this.Surname}, Age: {this.Age}, Position: {this.Position}, Salary: {this.Salary}");
        }

        public Employe(string name, string surname, int age, string position, decimal salary) : base(name, surname, age)
        {
            this.Position = position;
            this.Salary = salary;
            
        }

        public Employe ()
        {

        }








    }


}


