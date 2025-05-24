using NoteApp.Aplication.Interfaces;
namespace NoteApp.Infrastructure;

public class FileService : IFileService
{
    public void Append(string path, string content)
    {
        File.AppendAllText(path, content);
    }

    public string Read(string path)
    {
        return File.Exists(path) ? File.ReadAllText(path) : string.Empty;
    }

    public void Delete(string path)
    {
        if (File.Exists(path)) File.Delete(path);
    }

    public bool Exists(string path)
    {
        return File.Exists(path);
    }
}
