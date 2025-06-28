using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintJobManagementSystem.Models
{
    public class PrintJob
    {
        public string JobName { get; set; }
        public int EstimatedTime { get; set; } // in minutes

        public PrintJob(string jobName, int estimatedTime)
        {
            JobName = jobName;
            EstimatedTime = estimatedTime;
        }

        public override string ToString()
        {
            return $"{JobName}|{EstimatedTime}";
        }

        public static PrintJob FromString(string line)
        {
            var parts = line.Split('|');
            return new PrintJob(parts[0], int.Parse(parts[1]));
        }
    }
}
