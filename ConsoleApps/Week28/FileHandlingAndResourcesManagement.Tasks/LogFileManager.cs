using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAndResourcesManagement.Tasks
{
    public enum LogLevel
    {
        Information = 1,
        Warning = 2,
        Error = 3,
    }
    public interface ILogger : IDisposable
    {
        public void WriteLog(string message, LogLevel level);
        public void WriteError(string message);

        public long GetLogSize();

        public void WriteWarning(string message);

        public void WriteInformation(string message);
    }

    public class LogFileManager : ILogger
    {
        private readonly string _filePath;
        private StreamWriter _writer;
        private bool _disposed = false;

        
        public LogFileManager(string filePath)
        {
            _filePath = filePath;
            _writer = new StreamWriter(filePath, append: true);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~LogFileManager() { Dispose(false); }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_writer != null)
                    {
                        _writer.Flush();
                        _writer.Dispose();
                        _writer = null;
                    }

                }
                _disposed = true;


            }
        }

        public long GetLogSize()
        {
            _writer?.Flush();
            var fileInfo = new FileInfo(_filePath);
            return fileInfo.Length;
        }

        public void WriteError(string message)
        {
            WriteLog(message, LogLevel.Error);
            
        }

        public void WriteLog(string message, LogLevel level)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException(nameof(message));


            }

            if (_writer == null)
            {
                throw new ObjectDisposedException(nameof(LogFileManager));
            }

            var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [Level] : {level.ToString()} [Message]: {message}";

            _writer.WriteLine(logEntry);

            _writer.Flush();




        }

        public void WriteWarning(string message)
        {
            WriteLog(message, LogLevel.Warning);
        }

        public void WriteInformation(string message)
        {
            WriteLog(message, LogLevel.Information);
        }
    }


    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    
}
