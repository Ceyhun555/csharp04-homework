using System.Collections;

namespace Collections.NoneGenericStackClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a stack collection
            Stack stack = new Stack();

            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');
            //Printing the stack items using foreach loop
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();








            //Removing and Returning an item from the stack using the pop method
            Console.WriteLine($"\n\nDeleted Element: {stack.Pop()}");
            //Printing item after removing the last added item
            Console.WriteLine($"\nAll Stack Elements After Deletion: Count {stack.Count}");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();



            Console.WriteLine($"\nPeek element: {stack.Peek()}");

            Console.WriteLine($"\nAll Stack Elements After Peeking: Count {stack.Count}");

            foreach (var item in stack)
            {
                Console.Write($"{item}");
            }
            Console.ReadKey();

        }
    }
}
