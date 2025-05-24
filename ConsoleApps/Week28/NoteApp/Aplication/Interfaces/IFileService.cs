namespace NoteApp.Aplication.Interfaces
{
    public interface IFileService
    {
        void Append (string path, string content);

        string Read (string path);

        void Delete (string path);

        bool Exists (string path);
    }
}
