using System;
using System.Collections;
using System.IO;

public class TempFileManager : IDisposable
{
    private ArrayList tempFiles;
    private readonly string tempDirectory;

    public TempFileManager()
    {
        tempFiles = new ArrayList();
        tempDirectory = Path.GetTempPath();
    }

   
    //public void WriteTempData(string data)
    //{
    //    try
    //    {
    //        string tempFile = CreateTempFile();
    //        if (tempFile == null)
    //            return;

    //        using (StreamWriter writer = new StreamWriter(tempFile))
    //        {
    //            writer.Write(data);
    //        }

    //        Console.WriteLine($"Data written to temp file: {tempFile}");
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine("Error writing temp data: " + ex.Message);
    //    }
    //}

    public void CleanupTempFiles()
    {
        foreach (object obj in tempFiles)
        {
            string file = obj as string;
            try
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                    Console.WriteLine($"Deleted temp file: {file}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting file {file}: {ex.Message}");
            }
        }

        tempFiles.Clear();
    }

    public void CleanupOldFiles()
    {
        
    }

    public void Dispose()
    {
        CleanupTempFiles();
        GC.SuppressFinalize(this);
    }
}

