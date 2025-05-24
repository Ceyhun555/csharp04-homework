using System.IO;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FileHandling.FileClass
{
    public class File
    {
        /*
         The File class provides static methods for performing common operations on files:

         Create
         Read
         Write
         Append
         Copy
         Move
         Delete
         Check existence
         */


        //Creating a File
        File.Create("example.txt").Dispose();
        // Creates an empty file named example.txt.We call.Dispose() to immediately release the file handle.


        //Writing to a File
        File.WriteAllText("example.txt", "Hello, World!");
        //Overwrites the file with new content.

        
        //Reading from a File
        string content = File.ReadAllText("example.txt");
        Console.WriteLine(content);
        //Reads and prints the file content.


        //Appending Text to a File
        File.AppendAllText("example.txt", "\nThis is an appended line.");
        //Appends a new line to the existing content.


        // Checking if a File Exists
        if (File.Exists("example.txt"))
        {
            Console.WriteLine("The file exists.");
        }



         //Deleting a File
         File.Delete("example.txt");      
        //Permanently removes the file.




        //Copying and Moving Files
        File.Copy("example.txt", "backup.txt", overwrite: true);
        File.Move("backup.txt", "archive.txt");
        //Copies example.txt to backup.txt (overwriting if needed), then moves backup.txt to archive.txt.



        //Error Handling and Exceptions

        /*
        Common Exceptions:
        FileNotFoundException – File doesn't exist.
        IOException – General I/O error.
        UnauthorizedAccessException – No permission to access the file.
        DirectoryNotFoundException – Folder doesn't exist.
        */

        try
        {
           var content = File.ReadAllText("missing.txt");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Error: Access denied.");
        }








}   




}
