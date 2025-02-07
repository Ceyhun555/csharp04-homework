namespace Practice.OOP.Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Default constructor.
            Console.WriteLine("Default constructor.");
            Student student = new Student();

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Grade);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Major);
            Console.WriteLine();


            //Parameterized constructor1: Accept name and age.
            Console.WriteLine("Parameterized constructor1: Accept name and age.");
            Student student1 = new Student(age: 23,  name: "ceyhun " );

            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Grade);
            Console.WriteLine(student1.Age);
            Console.WriteLine(student1.Major);
            Console.WriteLine();



            //Parameterized constructor2: Accept name , major, age, grade.
            Console.WriteLine("Parameterized constructor2: Accept name , major, age, grade.");
            Student student2 = new Student( "ceyhun" ,  "Study",  23 ,  1);

            Console.WriteLine(student2.Name);
            Console.WriteLine(student2.Grade);
            Console.WriteLine(student2.Age);
            Console.WriteLine(student2.Major);
            Console.WriteLine();
        }



    }


   


}



