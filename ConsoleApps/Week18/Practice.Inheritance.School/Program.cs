namespace Practice.Inheritance.School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



        }
    }


    class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }
    }
    class Student :Person
    {
        

        public string Class { get; set; }

        public string Marks { get; set; }

        public string Grate { get; set; }


        public string Fees { get; set; }
    }

    class Staff :Person
    {
        public string Designation { get; set; }

        public decimal Salary { get; set; }
    }

    class TeachingStaff :Staff
    {
        

        public string Qualifacition { get; set; }

        public string Subject   { get; set; }


    }

    class NonTeachingStaff :Staff
    {
        
       

        public string DepartamentName { get; set; }

        public int MenagerId { get; set; }
    }






   


}
