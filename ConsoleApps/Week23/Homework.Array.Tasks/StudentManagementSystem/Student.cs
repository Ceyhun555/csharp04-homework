namespace Homework.Array.Tasks.StudentManagementSystem
{
    public class Student
    {
        public string Name { get; set; }

        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Grade: {this.Grade}";
        }
    }
}
