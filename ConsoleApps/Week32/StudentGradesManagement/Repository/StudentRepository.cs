using System.Collections;
using StudentGradesSystem.Models;

namespace StudentGradesSystem.Repositories
{
    public class StudentRepository
    {
        private readonly ArrayList students = new ArrayList();

        public ArrayList GetAll()
        {
            return students;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudentAt(int index)
        {
            students.RemoveAt(index);
        }

        public int Count()
        {
            return students.Count;
        }
    }
}

