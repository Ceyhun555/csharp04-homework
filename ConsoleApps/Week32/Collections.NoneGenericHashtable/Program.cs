using System.Collections;

namespace Collections.NoneGenericHashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * If you have a huge number of elements in the collection, then it is very difficult to remember the index position of each element.
             * So, it would not be nice, instead of using the index position of the element, we can access the elements by using a key. 
             * This is where Hashtable in C# comes into the picture.
             */

            ArrayList al = new ArrayList();

            al.Add(1001); //EId - Index Position = 0
            al.Add("James"); //Name - Index Position = 1
            al.Add("Manager"); //Job - Index Position = 2
            al.Add(3500); //Salary - Index Position = 3
            al.Add("Mumbai"); //Location - Index Position = 4
            al.Add("IT"); //Dept - Index Position = 5
            al.Add("a@a.com"); // Emailid - Index Position = 6
            //I want to print the Location, Index position is 4
            Console.WriteLine("Location : " + al[4]);
            //I want to print the Email ID, Index position is 6
            Console.WriteLine("Emaild ID : " + al[6]);
            Console.ReadKey();






            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();



            //Adding elements to the Hash table using key value pair
            hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
            hashtable.Add("Name", "James"); //Here key is Name and value is James
            hashtable.Add("Salary", 3500); //Here key is Salary and value is 3500
            hashtable.Add("Location", "Mumbai"); //Here key is Location and value is Mumbai
            hashtable.Add("EmailID", "a@a.com"); //Here key is EmailID and value is a@a.com
            //Printing the keys and their values using foreach loop
            Console.WriteLine("Printing Hashtable using Foreach Loop");
            foreach (object obj in hashtable.Keys)
            {
                Console.WriteLine(obj + " : " + hashtable[obj]); // key: hashtable["Name"] -> "James"
            }

            //Or
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            }
            Console.WriteLine("\nPrinting Hashtable using Keys");
            //I want to print the Location by using the Location key
            Console.WriteLine("Location : " + hashtable["Location"]);
            //I want to print the Email ID by using the EmailID key
            Console.WriteLine("Emaild ID : " + hashtable["EmailID"]);
            Console.ReadKey();







            //Creating a Hashtable using collection-initializer syntax
            Hashtable citiesHashtable = new Hashtable(){
                            {"UK", "London, Manchester, Birmingham"}, //Key:UK, Value:London, Manchester, Birmingham
                            {"USA", "Chicago, New York, Washington"}, //Key:USA, Value:Chicago, New York, Washington
                            {"India", "Mumbai, New Delhi, Pune"}      //Key:India, Value:Mumbai, New Delhi, Pune
                        };
            Console.WriteLine("Creating a Hashtable Using Collection-Initializer");
            foreach (DictionaryEntry city in citiesHashtable)
            {
                Console.WriteLine($"Key: {city.Key}, Value: {city.Value}");
            }
            Console.ReadKey();






            Hashtable hashtable1 = new Hashtable();
            hashtable[1] = "One";
            hashtable[5] = "Five";
            hashtable[30] = "Thirty";
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            }
            Console.ReadKey();




            //Creating Hashtable collection using collection-initializer syntax
            Hashtable employee = new Hashtable
            {
                { "EId", 1001 },
                { "Name", "James" },
                { "Salary", 3500 },
                { "Location", "Mumbai" },
                { "EmailID", "a@a.com" }
            };

            string employeeName = (string)employee["Name"]; //Cast to String
            int employeeSalary = (int)employee["Salary"];   //Cast to Int
            Console.WriteLine("Before Updating Name and Salary");
            Console.WriteLine($"Employee Name: {employeeName}");
            Console.WriteLine($"Employee Salary: {employeeSalary}");

            //Updating the Name and Salary
            employee["Name"] = "Smith"; //Update value of Name key
            employee["Salary"] = 5000; //Update value of Salary key
            Console.WriteLine("\nAfter Updating Name and Salary");
            employeeName = (string)employee["Name"];
            employeeSalary = (int)employee["Salary"];
            Console.WriteLine($"Employee Name: {employeeName}");
            Console.WriteLine($"Employee Salary: {employeeSalary}");

            Console.ReadKey();


            var employeeName1 = employee["Name"];





        }
    }
}
