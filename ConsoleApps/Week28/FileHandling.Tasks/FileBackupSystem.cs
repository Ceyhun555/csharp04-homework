using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Tasks
{
    public class FileBackupSystem
    {
        private readonly string _backupDirectory;

        public FileBackupSystem(string backupDirectory)
        {
            _backupDirectory = backupDirectory;

            if (!Directory.Exists(_backupDirectory))
            {
                Directory.CreateDirectory(_backupDirectory);
            }
        }

        public void CreateBackup(string sourceFile)
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string backupFileName = $"{Path.GetFileNameWithoutExtension(sourceFile)}_backup_{timestamp}{Path.GetExtension(sourceFile)}";
            string backupPath = Path.Combine(_backupDirectory, backupFileName);

            try
            {
                using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream backupStream = new FileStream(backupPath, FileMode.Create, FileAccess.Write))
                {
                    long totalBytes = sourceStream.Length;
                    byte[] buffer = new byte[8192];
                    int bytesRead;
                    long totalRead = 0;

                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        backupStream.Write(buffer, 0, bytesRead);
                        totalRead += bytesRead;

                        // Simple progress reporting
                        int progress = (int)((double)totalRead / totalBytes * 100);
                        Console.Write($"\rBacking up... {progress}%");
                    }

                    Console.WriteLine("\nBackup completed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during backup: {ex.Message}");
            }
        }

        public void RestoreFromBackup(string backupFile)
        {
            if (!File.Exists(backupFile))
            {
                Console.WriteLine("Backup file not found.");
                return;
            }

            string originalName = GetOriginalNameFromBackup(backupFile);

            try
            {
                using (FileStream backupStream = new FileStream(backupFile, FileMode.Open, FileAccess.Read))
                using (FileStream restoreStream = new FileStream(originalName, FileMode.Create, FileAccess.Write))
                {
                    long totalBytes = backupStream.Length;
                    byte[] buffer = new byte[8192];
                    int bytesRead;
                    long totalRead = 0;

                    while ((bytesRead = backupStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        restoreStream.Write(buffer, 0, bytesRead);
                        totalRead += bytesRead;

                        int progress = (int)((double)totalRead / totalBytes * 100);
                        Console.Write($"\rRestoring... {progress}%");
                    }

                    Console.WriteLine("\nRestore completed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during restore: {ex.Message}");
            }
        }

        public string[] ListBackups()
        {
            try
            {
                return Directory.GetFiles(_backupDirectory, "*_backup_*");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error listing backups: {ex.Message}");
                return new string[0];
            }
        }

        private string GetOriginalNameFromBackup(string backupFile)
        {
            string fileName = Path.GetFileName(backupFile);
            int index = fileName.IndexOf("_backup_");
            return index > 0 ? fileName.Substring(0, index) + Path.GetExtension(fileName) : "restored_file" + Path.GetExtension(fileName);
        }
    }
}
