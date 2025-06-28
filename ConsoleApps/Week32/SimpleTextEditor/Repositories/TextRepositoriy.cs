using System;
using System.IO;
using System.Collections;
using UndoTextEditor.Constants;

namespace UndoTextEditor.Repositories
{
    public class TextRepository
    {
        public Stack LoadTextFromFile()
        {
            Stack textStack = new Stack();

            if (File.Exists(Messages.FilePath))
            {
                string[] lines = File.ReadAllLines(Messages.FilePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    textStack.Push(lines[i]);
                }
            }

            return textStack;
        }

        public void SaveTextToFile(Stack textStack)
        {
            string[] lines = new string[textStack.Count];
            textStack.CopyTo(lines, 0);
            Array.Reverse(lines); 

            File.WriteAllLines(Messages.FilePath, lines);
        }
    }
}

