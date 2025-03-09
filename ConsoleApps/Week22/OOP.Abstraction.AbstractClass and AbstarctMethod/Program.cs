namespace OOP.Abstraction.AbstractClass_and_AbstarctMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe = new FullTimeEmploye("Ceyhun", "Ismayilov");
            Console.WriteLine($"Full Time Employe salary: {employe.GetSalary()}");
            employe.GetInfo();

            Employe employe2 = new ContractEmploye("Resad", "Kerimov");
            Console.WriteLine($"Contract Employe salary: {employe2.GetSalary()}");
            employe2.GetInfo();

        }
    }

    public abstract class Employe
    {
        public string Name {  get; set; }
        public string Surname { get; set; }

        public Employe (string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public abstract double GetSalary();

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}");
        }
        
    }

    public class FullTimeEmploye : Employe
    {
        public FullTimeEmploye(string name, string surname) : base(name, surname)
        {

        }

        public override double GetSalary()
        {
            return 5000;
        }
    }

    public class ContractEmploye : Employe
    {
        public ContractEmploye(string name, string surname) : base(name, surname)
        {

        }

        public override double GetSalary()
        {
            return 3000;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Contract Employe Info: Name: {Name}, Surname: {Surname}");
        }
    }
}
