namespace StaticClassTasks
{
    public static class MathUtilities
    {
        public static int Square(int number)
        {
            return number * number;
        }

        public static int Cube(int number)
        {
            return number * number * number;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1); 
            }
        }
    }
}
