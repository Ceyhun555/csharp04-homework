using System;
using System.IO;

public class DirectoryMonitor : IDisposable
{
    private readonly string directoryPath;
    private FileSystemWatcher watcher;
    private readonly string logFilePath;
    private bool isMonitoring = false;

    public DirectoryMonitor(string path)
    {
        if (!Directory.Exists(path))
        {
            throw new DirectoryNotFoundException($"Directory not found: {path}");
        }

        directoryPath = path;
        logFilePath = Path.Combine(directoryPath, "log.txt");

        watcher = new FileSystemWatcher(directoryPath);

        
    }

    public void StartMonitoring()
    {
        if (!isMonitoring)
        {
            watcher.EnableRaisingEvents = true;
            isMonitoring = true;
            Log("Monitoring started.");
        }
    }

    public void StopMonitoring()
    {
       
    }

    private void OnCreated()
    {
        
    }

    private void OnDeleted()
    {
        
    }

    private void OnChanged()
    {
        
    }

    private void Log(string message)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"[{DateTime.Now}] {message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to log message: " + ex.Message);
        }
    }

    public void Dispose()
    {
       
        GC.SuppressFinalize(this);
    }
}

