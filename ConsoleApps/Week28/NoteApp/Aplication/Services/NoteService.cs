using NoteApp.Domain.Entities;
using NoteApp.Aplication.Interfaces;

namespace NoteApp.Application.Services;

public class NoteService : INoteService
{
    private readonly IFileService _fileService;
    private readonly string _filePath = "notes.txt";

    public NoteService(IFileService fileService)
    {
        _fileService = fileService;
    }

    public void Create(string title, string content)
    {
        var note = new Note { Title = title, Content = content };
        var data = $"[{note.CreatedAt}] {note.Title}\n{note.Content}\n---\n";
        _fileService.Append(_filePath, data);
    }

    public string GetAll()
    {
        return _fileService.Exists(_filePath) ? _fileService.Read(_filePath) : "No notes available.";
    }

    public void Clear()
    {
        _fileService.Delete(_filePath);
    }

    public bool Any()
    {
        return _fileService.Exists(_filePath);
    }
}