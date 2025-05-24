using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Tasks
{
    public class TempFileManager : IDisposable
    {
        private string _tempDirectory;
        private string _fileIndexPath;
        private const int FileLifetimeMinutes = 30;
        private bool _disposed = false;

        public TempFileManager()
        {
            _tempDirectory = Path.Combine(Path.GetTempPath(), "ManagedTempFiles");

            if (!Directory.Exists(_tempDirectory))
            {
                Directory.CreateDirectory(_tempDirectory);
            }

            // Optional: index file to track the last temp file written to
            _fileIndexPath = Path.Combine(_tempDirectory, "latest.txt");

            CleanupOldFiles(); // Initial cleanup
        }

        public string CreateTempFile()
        {
            try
            {
                string tempFile = Path.Combine(_tempDirectory, $"temp_{Guid.NewGuid()}.tmp");
                using (File.Create(tempFile)) { }

                File.SetLastWriteTime(tempFile, DateTime.Now);
                File.WriteAllText(_fileIndexPath, tempFile);

                return tempFile;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating temp file: {ex.Message}");
                return null;
            }
        }


        public void WriteTempData(string data)
        {
            try
            {
                if (!File.Exists(_fileIndexPath))
                {
                    Console.WriteLine("No temporary file to write to. Use CreateTempFile() first.");
                    return;
                }

                string latestTempFile = File.ReadAllText(_fileIndexPath);

                if (!File.Exists(latestTempFile))
                {
                    Console.WriteLine("Tracked temp file no longer exists.");
                    return;
                }

                File.AppendAllText(latestTempFile, data + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to temp file: {ex.Message}");
            }
        }


        public void CleanupTempFiles()
        {
            try
            {
                string[] files = Directory.GetFiles(_tempDirectory, "temp_*.tmp");

                foreach (var file in files)
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Could not delete {file}: {ex.Message}");
                    }
                }

                if (File.Exists(_fileIndexPath))
                {
                    File.Delete(_fileIndexPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during cleanup: {ex.Message}");
            }
        }


        private void CleanupOldFiles()
        {
            try
            {
                string[] files = Directory.GetFiles(_tempDirectory, "temp_*.tmp");
                DateTime now = DateTime.Now;

                foreach (var file in files)
                {
                    DateTime lastWrite = File.GetLastWriteTime(file);
                    if ((now - lastWrite).TotalMinutes > FileLifetimeMinutes)
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error deleting old file {file}: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cleaning old files: {ex.Message}");
            }
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
                    CleanupTempFiles();
                }

                _disposed = true;
            }
        }

        ~TempFileManager()
        {
            Dispose(false);
        }


    }
}
