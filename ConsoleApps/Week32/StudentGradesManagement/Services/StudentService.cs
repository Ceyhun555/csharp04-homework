using System;
using System.Collections;
using StudentGradesSystem.Models;
using StudentGradesSystem.Repositories;
using StudentGradesSystem.Constants;

namespace StudentGradesSystem.Services
{
    public class StudentService
    {
        private readonly StudentRepository repo = new StudentRepository();

        public void AddStudent()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine(Messages.InvalidName);
                return;
            }

            if (ExistsByName(name))
            {
                Console.WriteLine(Messages.DuplicateStudent);
                return;
            }

            Console.Write("Enter grade: ");
            string gradeInput = Console.ReadLine();
            double grade;
            if (!double.TryParse(gradeInput, out grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine(Messages.InvalidGrade);
                return;
            }

            Student student = new Student { Name = name, Grade = grade };
            repo.AddStudent(student);
            Console.WriteLine(Messages.StudentAdded);
        }

        public void ShowAllStudents()
        {
            ArrayList students = repo.GetAll();
            if (students.Count == 0)
            {
                Console.WriteLine(Messages.NoStudents);
                return;
            }

            students.Sort(new GradeComparer());

            Console.WriteLine("Students (sorted by grade):");
            foreach (object obj in students)
            {
                if (obj is Student s)
                {
                    Console.WriteLine("Name: {0,-10} | Grade: {1}", s.Name, s.Grade);
                }
            }
        }

        public void ShowAverageGrade()
        {
            ArrayList students = repo.GetAll();
            if (students.Count == 0)
            {
                Console.WriteLine(Messages.NoStudents);
                return;
            }

            double total = 0;
            int count = 0;

            foreach (object obj in students)
            {
                if (obj is Student s)
                {
                    total += s.Grade;
                    count++;
                }
            }

            double average = total / count;
            Console.WriteLine("📊 Average Grade: {0:F2}", average);
        }

        public void RemoveStudentByName()
        {
            Console.Write("Enter name to remove: ");
            string nameToRemove = Console.ReadLine().Trim().ToLower();

            ArrayList students = repo.GetAll();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i] is Student s)
                {
                    if (s.Name.ToLower() == nameToRemove)
                    {
                        repo.RemoveStudentAt(i);
                        Console.WriteLine(string.Format(Messages.StudentRemoved, s.Name));
                        return;
                    }
                }
            }

            Console.WriteLine(Messages.StudentNotFound);
        }

        private bool ExistsByName(string name)
        {
            ArrayList students = repo.GetAll();
            foreach (object obj in students)
            {
                if (obj is Student s)
                {
                    if (s.Name.ToLower() == name.ToLower())
                        return true;
                }
            }

            return false;
        }
    }

    class GradeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Student s1 = x as Student;
            Student s2 = y as Student;
            return s2.Grade.CompareTo(s1.Grade); // descending
        }
    }
}
