using PrintJobManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintJobManagementSystem.Services
{
    public class PrintQueueService
    {
        private const string FilePath = "printqueue.txt";
        private Queue<PrintJob> queue = new Queue<PrintJob>();

        public PrintQueueService()
        {
            LoadQueueFromFile();
        }

        public void AddJob()
        {
            Console.Write("Enter job name: ");
            string name = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("❌ Job name cannot be empty.");
                return;
            }

            Console.Write("Enter estimated print time (minutes): ");
            if (!int.TryParse(Console.ReadLine(), out int minutes) || minutes <= 0)
            {
                Console.WriteLine("❌ Invalid print time.");
                return;
            }

            queue.Enqueue(new PrintJob(name, minutes));
            Console.WriteLine("Print job added to queue.");
        }

        public void ProcessNextJob()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("No jobs in the queue.");
                return;
            }

            var job = queue.Dequeue();
            Console.WriteLine($"Processing: {job.JobName}");
            Console.WriteLine("Print job completed!");
        }

        public void ViewPendingJobs()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("No pending print jobs.");
                return;
            }

            Console.WriteLine("Pending Print Jobs:");
            int index = 1;
            foreach (var job in queue)
            {
                Console.WriteLine($"{index++}. {job.JobName} ({job.EstimatedTime} minutes)");
            }
        }

        public void ShowEstimatedWaitTime()
        {
            int totalMinutes = 0;
            foreach (var job in queue)
            {
                totalMinutes += job.EstimatedTime;
            }

            Console.WriteLine($"Estimated wait time: {totalMinutes} minutes");
        }

        public void ClearQueue()
        {
            queue.Clear();
            Console.WriteLine("Queue cleared.");
        }

        public void SaveAndExit()
        {
            try
            {
                File.WriteAllLines(FilePath, ConvertQueueToLines());
                Console.WriteLine("💾 Changes saved. Exiting...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to save file: {ex.Message}");
            }
        }

        private void LoadQueueFromFile()
        {
            if (!File.Exists(FilePath)) return;

            try
            {
                foreach (string line in File.ReadAllLines(FilePath))
                {
                    queue.Enqueue(PrintJob.FromString(line));
                }
            }
            catch
            {
                Console.WriteLine("Error loading saved queue. Starting with an empty queue.");
            }
        }

        private IEnumerable<string> ConvertQueueToLines()
        {
            foreach (var job in queue)
            {
                yield return job.ToString();
            }
        }
    }
}
