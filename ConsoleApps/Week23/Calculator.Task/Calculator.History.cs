using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Task
{
    public partial class Calculator
    {
        private string _history = string.Empty;

        
        partial void OnCalculationPerformed(string calculationEvent)
        {
            _history += calculationEvent;
        }

        
        public void DisplayHistory()
        {
            Console.WriteLine("Calculation History:");
            Console.WriteLine(_history);
        }
    }

}
