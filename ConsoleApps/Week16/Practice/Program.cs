using TasksCar;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe1 = new Employe("Togrul",  "Memmedov", "Operator", new DateTime(1994, 8, 25));


            Console.WriteLine($"Employe1: {employe1.Name} {employe1.Surname} {employe1.Duty} {employe1.Birthday} age: {employe1.Age} ");

            Employe employe2 = new Employe();

            employe2.Name = "Ibrahim";
            employe2.Surname = "Qudretli";
            employe2.Birthday = new DateTime(1997, 10, 15);

            //employe2.FullName = "asdhsvds";


            Console.WriteLine($"Employe2: {employe2.Name} {employe2.Surname} {employe2.Birthday}");
            Console.WriteLine($"Employe2: {employe2.FullName} {employe2.Birthday}");


            //Car newCar = new();
        }
    }
}
