using System;
using System.Collections;
using UndoTextEditor.Constants;
using UndoTextEditor.Repositories;

namespace UndoTextEditor.Services
{
    public class TextEditorService
    {
        private Stack _textStack;
        private readonly TextRepository _repo;

        public TextEditorService()
        {
            _repo = new TextRepository();
            _textStack = _repo.LoadTextFromFile();
        }

        public void TypeNewText()
        {
            Console.Write("Enter new line: ");
            string input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Text cannot be empty.");
                return;
            }

            if (_textStack.Count > 0)
            {
                string last = (string)_textStack.Peek();
                if (last == input)
                {
                    Console.WriteLine("Cannot add the same line twice in a row.");
                    return;
                }
            }

            _textStack.Push(input);
            Console.WriteLine(Messages.TextAdded);
        }

        public void UndoLastEntry()
        {
            if (_textStack.Count == 0)
            {
                Console.WriteLine(Messages.NothingToUndo);
                return;
            }

            string removed = (string)_textStack.Pop();
            Console.WriteLine(Messages.UndoSuccess + removed);
        }

        public void ViewText()
        {
            if (_textStack.Count == 0)
            {
                Console.WriteLine("No text yet.");
                return;
            }

            Console.WriteLine("\nCurrent text (most recent first):");
            foreach (object line in _textStack)
            {
                Console.WriteLine(line);
            }
        }

        public void ClearAll()
        {
            _textStack.Clear();
            Console.WriteLine(Messages.Cleared);
        }

        public void SaveAndExit()
        {
            _repo.SaveTextToFile(_textStack);
            Console.WriteLine(Messages.Saved);
        }
    }
}
