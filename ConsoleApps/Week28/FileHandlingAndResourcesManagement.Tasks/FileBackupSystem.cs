using System;
using System.IO;

public class FileBackupSystem
{
    private string backupDirectory;

    public FileBackupSystem(string backupDirectory)
    {
        this.backupDirectory = backupDirectory;

        if (!Directory.Exists(backupDirectory))
        {
            Directory.CreateDirectory(backupDirectory);
        }
    }

    public void CreateBackup(string sourceFile)
    {
        
    }

    public void RestoreFromBackup(string backupFile)
    {
       
    }

    
    
}

