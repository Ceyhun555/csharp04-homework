namespace Homework.Array.Tasks.StudentManagementSystem
{
    class StudentManager
    {
        private Student[] students;
        private int count;

        public StudentManager(int size)
        {
            students = new Student[size];
            count = 0;
        }

        public void AddStudent(string name, int grade)
        {
            if (count < students.Length)
            {
                students[count++] = new Student(name, grade);
            }
        }

        public int GetHighestGrade()
        {
            if (count == 0)
            {
                return 0;
            }

            int max = students[0].Grade;
            for (int i = 1; i < count; i++)
            {
                if (students[i].Grade > max)
                    max = students[i].Grade;
            }
            return max;
        }

        public int GetLowestGrade()
        {
            if (count == 0)
            {
                return 0;
            }

            int min = students[0].Grade;
            for (int i = 1; i < count; i++)
            {
                if (students[i].Grade < min)
                    min = students[i].Grade;
            }
            return min;
        }

        public double GetAverageGrade()
        {
            if (count == 0)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += students[i].Grade;
            }
            return (double)sum / count;
        }

        public void SortByGrade()
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                //Console.WriteLine(students[i]);
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].Grade > students[j].Grade)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }

        public Student SearchByName(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (students[i].Name == name)
                    return students[i];
            }
            return null;
        }

        public void DisplayStudents()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Name: {students[i].Name}, Grade: {students[i].Grade}");
            }
        }
    }
}