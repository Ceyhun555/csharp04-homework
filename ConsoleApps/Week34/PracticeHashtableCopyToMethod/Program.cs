using System.Collections;

namespace PracticeHashtableCopyToMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Hashtable hashtable = new Hashtable();


            hashtable.Add("Eld", 1001);
            hashtable.Add("Name", "James");
            hashtable.Add("Location", "Mumbai");

            Console.WriteLine("Hashtable Elements: ");
            foreach (DictionaryEntry item in hashtable) 
            { 
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");


            }


            //Copying the Hashtable to an object array
            DictionaryEntry[] myArray = new DictionaryEntry[hashtable.Count]; 

            hashtable.CopyTo(myArray,0);

            Console.WriteLine("\nHashtable Copy Array elements: ");

            foreach(DictionaryEntry item in myArray)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Object[] myObjArrayKey = new Object[hashtable.Count];

            Object[] myObjArrayValue = new object[hashtable.Count];

            Console.WriteLine("\nCopyTo Method to copy Keys: ");
            hashtable.Keys.CopyTo(myObjArrayKey, 0);

            foreach (var key in myObjArrayKey) 
            {
                Console.WriteLine($"{key} ");

            }

            Console.WriteLine("\nCopyTo method to copy Values: ");
            hashtable.Values.CopyTo(myObjArrayValue, 0);
            foreach(var value in myObjArrayValue)
            {
                Console.WriteLine($"{value}");
            }

        }
    }
}
