using System.Collections;

namespace ArrayListPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            ArrayList arrayList = new ArrayList(5);

            arrayList.Add("Hello");






            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add("James"); //Adding Duplicate Value
            arrayList1.Add(" "); //Adding Empty
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            arrayList1.Add(null); //Adding null
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            //Adding Elements to ArrayList using object initializer syntax
            var arrayList2 = new ArrayList()
            {
                102, "Smith", "Smith", true, 15.6
            };
            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();



            //Adding elements to ArrayList using Add() method
            ArrayList arrayList3 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add("James"); //Adding Duplicate Value
            arrayList1.Add(" "); //Adding Empty
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            arrayList1.Add(null); //Adding null
            foreach (var item in arrayList3)
            {
                Console.WriteLine(item);
            }
            //Adding Elements to ArrayList using object initializer syntax
            var arrayList4 = new ArrayList()
            {
                102, "Smith", "Smith", true, 15.6
            };
            foreach (var item in arrayList4)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();




            ArrayList arrayLis5 = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal",
                    "HongKong",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "HongKong",
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayLis5)
            {
                Console.Write($"{item} ");
            }
            arrayList.Remove("HongKong"); //Removes first occurance of null
            Console.WriteLine("\n\nArray List Elements After Removing First Occurances of HongKong");
            foreach (var item in arrayLis5)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveAt(3); //Removes element at index postion 3, it is 0 based index
            Console.WriteLine("\n\nArray List1 Elements After Removing Element from Index 3");
            foreach (var item in arrayLis5)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            Console.WriteLine("\n\nArray List Elements After Removing First Two Elements");
            foreach (var item in arrayLis5)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
