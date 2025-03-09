using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Task
{
    public partial class Calculator
    {
        
        public double Multiply(double a, double b)
        {
            double result = a * b;
            OnCalculationPerformed($"Multiplied {a} and {b}: Result = {result}");
            return result;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                OnCalculationPerformed("Attempted to divide by zero");
                return 
            }

            double result = a / b;
            OnCalculationPerformed($"Divided {a} by {b}: Result = {result}");
            return result;
        }
    }

}
