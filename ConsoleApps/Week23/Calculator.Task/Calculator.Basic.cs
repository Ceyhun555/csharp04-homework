using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Task
{
    public partial class Calculator
    {
        
        public double Add(double a, double b)
        {
            double result = a + b;
            OnCalculationPerformed($"Added {a} and {b}: Result = {result}");
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            OnCalculationPerformed($"Subtracted {b} from {a}: Result = {result}");
            return result;
        }

       
        partial void OnCalculationPerformed(string calculationEvent);
    }
}
