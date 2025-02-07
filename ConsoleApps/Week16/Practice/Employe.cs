using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Employe
    {
        
        public string Name { get; set; }

        public string Surname { get; set; }
        /// <summary>
        /// Name + Surname ?
        /// </summary>


        //public string FullName => $"{Name} {Surname}";



        public string FullName
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }




        /// <summary>
        /// calculate age with birthday 
        /// </summary>
        //public int Age
        //{
        //    get
        //    {
        //        return DateTime.Now.Year - Birthday.Year;
        //    }
        //}

        public int Age { get; private set; }

        public string Duty { get; set; }

        public DateTime Birthday { get; set; }


        public Employe()
        {
            Duty = "Operator";

            Console.WriteLine("Default Constructor Work");
        }



        public Employe(string name, string surname) : this()
        {
            Name = name;
            Surname = surname;

            // version 1
            //FullName = $"{Name} {Surname}";

            Console.WriteLine($"Parametrized Constructor Work 1");
        }




        public Employe(string name,  string surname, string duty, DateTime birthday):this(name, surname)
        {
            //Name = name;          
            //Surname = surname;
            Duty = duty;
            Birthday = birthday;

            CalcAge();

            Console.WriteLine("Parametrized Constructor Work 2");

        }

        
        private void CalcAge()
        {
            Age = DateTime.Now.Year - Birthday.Year;
        }

        
        



    }
}
