using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Tasks.Documents
{
    abstract class Document
    {
        public abstract string Title { get; set; }
        public abstract string Author { get; set; }
        public abstract DateTime CreatedDate { get; set; }

        public abstract void Convert(string format);
        public abstract bool Validate();
        public abstract string GetDocumentInfo();

        public void DisplayMetadata()
        {
            Console.WriteLine(GetDocumentInfo());
        }
    }

    // Concrete PDF Document Class
    class PDFDocument : Document
    {
        public override string Title { get; set; }
        public override string Author { get; set; }
        public override DateTime CreatedDate { get; set; }

        public PDFDocument(string title, string author, DateTime createdDate)
        {
            Title = title;
            Author = author;
            CreatedDate = createdDate;
        }

        public override void Convert(string format)
        {
            Console.WriteLine($"Converting PDF document '{Title}' to {format} format.");
        }

        public override bool Validate()
        {
            return true;
        }

        public override string GetDocumentInfo()
        {
            return $"PDF Document - Title: {Title}, Author: {Author}, Created: {CreatedDate}";
        }
    }

    // Concrete Word Document Class
    class WordDocument : Document
    {
        public override string Title { get; set; }
        public override string Author { get; set; }
        public override DateTime CreatedDate { get; set; }

        public WordDocument(string title, string author, DateTime createdDate)
        {
            Title = title;
            Author = author;
            CreatedDate = createdDate;
        }

        public override void Convert(string format)
        {
            Console.WriteLine($"Converting Word document '{Title}' to {format} format.");
        }

        public override bool Validate()
        {
            return true;
        }

        public override string GetDocumentInfo()
        {
            return $"Word Document - Title: {Title}, Author: {Author}, Created: {CreatedDate}";
        }
    }

    // Concrete Spreadsheet Document Class
    class SpreadsheetDocument : Document
    {
        public override string Title { get; set; }
        public override string Author { get; set; }
        public override DateTime CreatedDate { get; set; }

        public SpreadsheetDocument(string title, string author, DateTime createdDate)
        {
            Title = title;
            Author = author;
            CreatedDate = createdDate;
        }

        public override void Convert(string format)
        {
            Console.WriteLine($"Converting Spreadsheet document '{Title}' to {format} format.");
        }

        public override bool Validate()
        {
            return true;
        }

        public override string GetDocumentInfo()
        {
            return $"Spreadsheet Document - Title: {Title}, Author: {Author}, Created: {CreatedDate}";
        }
    }

    // Document Processor Class
    class DocumentProcessor
    {
        public void ProcessDocument(Document doc)
        {
            Console.WriteLine("Processing document...");
            if (doc.Validate())
            {
                doc.DisplayMetadata();
                doc.Convert("txt"); // Example format conversion
            }
            else
            {
                Console.WriteLine("Invalid document format!");
            }
        }
    }
}
