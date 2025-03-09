using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Interface.Tasks.LoggingSystem
{
    internal interface ILogger
    {
        void LogInformation(string message);

        void LogWarning(string message);

        void LogError(string message);

        string[] GetLatestLogs(int count);
    }



    public class ConsoleLogger : ILogger
    {

        string[] logs = new string[100];
        private int logCount = 0;

        public string[] GetLatestLogs(int count)
        {
            int startIndex = Math.Max(0, logCount - count);
            return logs[startIndex..logCount]; // logs.TakeLast(count).ToArray();
        }

        public void LogError(string message)
        {
            LogMessage(level: "error", message, ConsoleColor.Red);
        }

        public void LogInformation(string message)
        {
            LogMessage(level: "info", message, ConsoleColor.Green);
        }

        public void LogWarning(string message)
        {
            LogMessage(level: "warning", message, ConsoleColor.Yellow);
        }


        private void LogMessage(string level, string message, ConsoleColor color)
        {
            string log = $"[{level}]- {DateTime.Now}: {message}";

            if (logCount < logs.Length)
            {
                logs[logCount++] = level;
            }

            Console.ForegroundColor = color;
            Console.WriteLine(log);
            Console.ResetColor();

        }
    }


    public class FileLogger : ILogger

    {
        public string[] GetLatestLogs(int count)
        {
            throw new NotImplementedException();
        }

        public void LogError(string message)
        {
            LogMessage(level: "error", message, ConsoleColor.Red);
        }

        public void LogInformation(string message)
        {
            LogMessage(level: "info", message, ConsoleColor.Green);
        }

        public void LogWarning(string message)
        {
            LogMessage(level: "warning", message, ConsoleColor.Yellow);
        }

        public void LogMessage(string level, string message, ConsoleColor color)
        {
            string log = $"[{level}]- {DateTime.Now}: {message}";
            Console.ForegroundColor = color;
            Console.WriteLine(log);
            Console.ResetColor();

        }
    }


}
