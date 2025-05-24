using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Examples
{
    public class LogFileManager : IDisposable
    {
        private readonly string _filePath;
        private StreamWriter _writer;
        private bool _disposed = false;


        public LogFileManager(string filePath)
        {
            _filePath = filePath;
            _writer = new StreamWriter(_filePath, append: true, encoding: Encoding.UTF8)
            {
                AutoFlush = true
            };

        }

        public void WriteLog(string message)
        {
            EnsureNotDisposed();
            _writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [INFO]: {message}");
        }

        public void WriteError(string error)
        {
            EnsureNotDisposed();
            _writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [ERROR]: {error}");
        }

        public long GetLogSize()
        {
            EnsureNotDisposed();
            _writer.Flush(); // Ensure everything is written before checking the file size
            var fileInfo = new FileInfo(_filePath);
            return fileInfo.Length;
        }

        private void EnsureNotDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(LogFileManager));
        }

        // Dispose pattern
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources
                    if (_writer != null)
                    {
                        _writer.Close();
                        _writer.Dispose();
                        _writer = null;
                    }
                }

                _disposed = true;
            }
        }

        ~LogFileManager()
        {
            Dispose(false);
        }
    }
}
