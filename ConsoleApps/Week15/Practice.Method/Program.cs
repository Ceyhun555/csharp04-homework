namespace Practice.Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Add(2, 4);
            double sum2 = Add(3, 7);
        }


        static int Add (int a, int b)
        {
            return a + b;
            
        }

        static double Add(double a, double b)
        {
            return (double)a + b;
        }

        

    }
}
