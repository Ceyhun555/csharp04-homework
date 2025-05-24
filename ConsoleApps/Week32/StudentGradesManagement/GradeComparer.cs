using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement
{
    public class GradeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Student student1 = x as Student;
            Student student2 = y as Student;
            return student2.Grade.CompareTo(student1.Grade);
        }
    }
}
