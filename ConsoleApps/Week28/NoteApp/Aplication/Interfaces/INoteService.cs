namespace NoteApp.Aplication.Interfaces
{
    public interface INoteService
    {
        void Create(string title, string content);

        string GetAll();

        void Clear();

        bool Any();
    }
}
