using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Tasks
{
    public class DirectoryMonitor : IDisposable
    {
        private readonly string _directoryPath;
        private readonly string _logFilePath;
        private FileSystemWatcher _watcher;
        private StreamWriter _logWriter;
        private bool _disposed = false;


        public DirectoryMonitor(string directoryPath)
        {
            _directoryPath = directoryPath;
            _logFilePath = Path.Combine(_directoryPath, "directory_changes.log");

            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }

            _logWriter = new StreamWriter(_logFilePath, append: true)
            {
                AutoFlush = true
            };

            _watcher = new FileSystemWatcher(_directoryPath)
            {
                IncludeSubdirectories = false,
                EnableRaisingEvents = false,
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite
            };

            _watcher.Created += OnCreated;
            _watcher.Deleted += OnDeleted;
            _watcher.Changed += OnChanged;
            _watcher.Renamed += OnRenamed;

        }
        public void StartMonitoring()
        {
            _watcher.EnableRaisingEvents = true;
            Log("Monitoring started.");
        }

        public void StopMonitoring()
        {
            _watcher.EnableRaisingEvents = false;
            Log("Monitoring stopped.");
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Log($"[Created] {e.FullPath}");
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Log($"[Deleted] {e.FullPath}");
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Log($"[Modified] {e.FullPath}");
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Log($"[Renamed] From: {e.OldFullPath} To: {e.FullPath}");
        }

        private void Log(string message)
        {
            _logWriter.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {message}");
        }

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
                    if (_watcher != null)
                    {
                        _watcher.EnableRaisingEvents = false;
                        _watcher.Created -= OnCreated;
                        _watcher.Deleted -= OnDeleted;
                        _watcher.Changed -= OnChanged;
                        _watcher.Renamed -= OnRenamed;
                        _watcher.Dispose();
                        _watcher = null;
                    }

                    if (_logWriter != null)
                    {
                        _logWriter.Flush();
                        _logWriter.Close();
                        _logWriter.Dispose();
                        _logWriter = null;
                    }
                }

                _disposed = true;
            }
        }

        ~DirectoryMonitor()
        {
            Dispose(false);
        }
    }
}
