using System.Security.Cryptography.X509Certificates;

namespace OOP.Polymorphism.Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe = new Employe("Ceyhun", "Ismayilov", 23);
            employe.Print("Ceyhun", "Ismayilov", 23);
            employe.Print("Ceyhun", "Ismayilov", 23, "Devoloper");
            Employe employe1 = new Employe("Ceyhun", "Ismayilov", 23, "Devoloper");

        }

    }


    public class Employe
    {
        public string Name {  get; set; }

        public int Age { get; set; }
        public string Surname {  get; set; }

        public string Position {  get; set; }

        public void Print (string name,  string surname, int age)
        {
            Console.WriteLine($"Name: {name},  Surname: {surname}, Age: {age}");
        }

        public void Print(string name , string surname, int age, string position)
        {
            Console.WriteLine($"Name: {name},  Surname: {surname}, Age: {age}, Position: {position}");
        }



        public Employe (string name, string surname, int age)
        {
            Name = name;
            Age = age;
            Surname = surname;
        }
        
        public Employe(string name, string surname, int age, string position) :this(name, surname, age)
        {
            Position = position;
        }


    }


}
