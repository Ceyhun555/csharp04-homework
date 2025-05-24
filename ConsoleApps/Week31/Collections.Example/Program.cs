using System.Collections;

namespace Collections.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            

            //Arraylist
            ArrayList arrayList = new ArrayList();
            Console.WriteLine($"Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");
            arrayList.Add(30);
            Console.WriteLine($"Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");
            arrayList.Add("salam");
            Console.WriteLine($"Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");
            arrayList.Add(24);
            Console.WriteLine($"Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");
            arrayList.Add("ceyhun");
            Console.WriteLine($"Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");
            arrayList.Add(15.5);
            Console.WriteLine($"Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");

            int firstElement = (int)arrayList[0];
            var explicitFirstElement = arrayList[1];
            string secondElement = (string)arrayList[1];
            

            for(int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"arrayList[{i}] : arrayList[i] Type: {arrayList[i].GetType()} ");

            }

            //Update element 

            arrayList[0] = "Hello";
            Console.WriteLine($"Arraylist : {arrayList[0]}");


            ArrayList arrayList1 = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal"
            };

            arrayList1.Insert(1, "Ukrayna");

            ArrayList arrayList2 = new ArrayList()
            {
                "Canada",
                "Russia",
                "Baku",
                "Turkiye"
            };

            arrayList2.InsertRange(3, arrayList1);
            Console.WriteLine();

        }
    }
}
