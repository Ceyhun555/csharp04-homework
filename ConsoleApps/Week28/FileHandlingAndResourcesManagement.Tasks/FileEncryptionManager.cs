using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class FileEncryptionManager : IDisposable
{
    private const int BufferSize = 5000;
    private const int SaltSize = 14;
    private const int KeySize = 30;
    private const int Iterations = 100_000;

    public void EncryptFile(string sourceFile, string destinationFile, string password)
    {
       
        
    }

    public void DecryptFile(string sourceFile, string destinationFile, string password)
    {
       
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}

