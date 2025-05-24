using System.IO;

namespace FileHandling.Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //string path = "example.txt";
            //string content = "Hello, this is a sample text.";
            //File.WriteAllText(path, content);

            //using (StreamWriter writer = new StreamWriter("example.txt"))
            //{
            //    writer.WriteLine("This is line 1.");
            //    writer.WriteLine("This is line 2.");
            //}

            //StreamWriter writer2 = new StreamWriter("example.txt");
            //writer2.WriteLine("This is line 1.");
            //writer2.Dispose();




            //string content2 = File.ReadAllText("example.txt");
            //Console.WriteLine(content2);





            //using (StreamReader reader = new StreamReader("example.txt"))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}


            //File.AppendAllText("example.txt", "\nThis is appended text.");







            //using (StreamWriter writer = new StreamWriter("example.txt", true))
            //{
            //    writer.WriteLine("Appended line.");
            //}



            //if (File.Exists("example.txt"))
            //{
            //    File.Delete("example.txt");
            //    Console.WriteLine("File deleted successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("File not found.");
            //}

            string filePath = "example2.txt";

            FileInfo fileInfo = new FileInfo(filePath);

            using (FileStream fileStream = fileInfo.Open(FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine("Hello World, My name is Ceyhun");
                }


            }



            fileInfo.Refresh();

            Console.WriteLine($"File Size:  {fileInfo.Length} bytes.");



            using (FileStream fs = new FileStream("examplenew.txt", FileMode.Create))
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("Binary Data Example");
                fs.Write(data, 0, data.Length);
            }



            string filePath1 = "example4.txt";

            FileInfo fileInfo1 = new FileInfo(filePath1);

            using FileStream fileStream1 = fileInfo1.Open(FileMode.Create, FileAccess.ReadWrite, FileShare.Read);

            using StreamWriter streamWriter1 = new StreamWriter(fileStream1);

            streamWriter1.WriteLine("Hello World, My name is Ceyhun. I am developer.");


            streamWriter1.Flush();
            fileStream1.Flush();

            fileInfo1.Refresh();

            Console.WriteLine($"File Size:  {fileInfo1.Length} bytes.");






            // Create a folder if it doesn’t exist
            Directory.CreateDirectory("MyFolder");

            // List all files in current folder
            string[] files = Directory.GetFiles("."); // '.' means current directory
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }




        }





    }
}
