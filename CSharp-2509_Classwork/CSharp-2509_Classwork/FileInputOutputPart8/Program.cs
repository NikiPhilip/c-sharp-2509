using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileInputOutputPart8
{
    public class Program
    {
        static void Main(string[] args)
        {

            //1.Write a C# program that performs the following tasks: 
            // Creates a directory named "MyTestDirectory" if it doesn’t exist. 
            // Creates a file named "testfile.txt" inside "MyTestDirectory".
            // Writes "Hello, C#!" to "testfile.txt".
            // Reads the contents of "testfile.txt" and displays it on the console. 
            // Deletes "testfile.txt" and "MyTestDirectory" after displaying the contents. 
            //string dirPath = "MyTestDirectory";
            //string filePath = Path.Combine(dirPath, "testfile.txt");

            //// Create directory if it doesn't exist 
            //if (!Directory.Exists(dirPath))
            //{
            //    Directory.CreateDirectory(dirPath);
            //}

            //// Create and write to file 
            //File.WriteAllText(filePath, "Hello, C#!");

            //// Read and display file contents 
            //string fileContent = File.ReadAllText(filePath);
            //Console.WriteLine("File Content: " + fileContent);

            ////Clean up by deleting file and directory
            //File.Delete(filePath);
            //Directory.Delete(dirPath);

            //Console.WriteLine("File and Directory deleted successfully.");
            //Console.ReadLine();


            //2.Write a program in C# that reads a text file "sample.txt" line by line using StreamReader and 
            //writes each line to a new file named "copy.txt" using StreamWriter.

            //string sourcefilepath = "sample.txt";
            //string destinationFilePath = "copy.txt";

            //using (StreamReader reader = new StreamReader(sourcefilepath))
            //using (StreamWriter writer = new StreamWriter(destinationFilePath))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        writer.WriteLine(line);
            //    }
            //}
            //Console.WriteLine("File copied successfully");
            //Console.ReadLine();

            //3.



            //4.Modify the file copy program in Question 2 to handle possible exceptions like 
            //FileNotFoundException, UnauthorizedAccessException, and IOException. Display custom error
            //messages for each exception type.

            //string sourceFilePath = "sample.txt";
            //string destinationFilePath = "copy.txt";

            //try
            //{
            //    using (StreamReader reader = new StreamReader(sourceFilePath))
            //    using (StreamWriter writer = new StreamWriter(destinationFilePath))
            //    {
            //        string line;
            //        while ((line = reader.ReadLine()) != null)
            //        {
            //            writer.WriteLine(line);
            //        }
            //    }

            //    Console.WriteLine("File copied successfully.");
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("Error: Source file not found.");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (UnauthorizedAccessException ex)
            //{
            //    Console.WriteLine("Error: Access denied. Check permissions.");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("Error: IO exception occurred.");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An unexpected error occurred.");
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();


            //5. Write a C# program that searches for all .txt files within a directory named "Logs". For each .txt 
            //            file found: 
            // Append the current timestamp at the end of the file. 
            // Display the filename and its content after modification. 
            //If the "Logs" directory doesn’t exist, create it, add a sample file, and notify the user.

            //string dirPath = "Logs";
            //Directory.CreateDirectory(dirPath);

            //string sampleFilePath = Path.Combine(dirPath, "sample.txt");
            //if (!File.Exists(sampleFilePath))
            //{
            //    File.WriteAllText(sampleFilePath, "Sample log entry.");
            //    Console.WriteLine("Sample file created in Logs directory.");
            //}

            //// Search for .txt files and modify them 
            //foreach (string filePath in Directory.GetFiles(dirPath, "*.txt"))
            //{
            //    // Append timestamp 
            //    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //    File.AppendAllText(filePath, $"\n{timestamp}");

            //    // Display file content after modification 
            //    string content = File.ReadAllText(filePath);
            //    Console.WriteLine($"File: {filePath}\nContent:\n{content}");
            //    Console.ReadLine();


            //}

            //6.Create a C# program that: 
            // Writes an array of integers { 10, 20, 30, 40, 50}
            //            to a binary file named "data.bin".
            // Reads the integers from "data.bin" and displays them on the console. 
            //Use BinaryWriter and BinaryReader classes for this operation.

            //string filePath = "data.bin";
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //// Write integers to binary file 
            //using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            //{
            //    foreach (int number in numbers)
            //    {
            //        writer.Write(number);
            //    }
            //}

            //Console.WriteLine("Data written to binary file.");

            //// Read integers from binary file 
            //using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            //{
            //    Console.WriteLine("Reading data from binary file:");
            //    while (reader.BaseStream.Position != reader.BaseStream.Length)
            //    {
            //        int number = reader.ReadInt32();
            //        Console.WriteLine(number);
            //    }
            //}
            //Console.ReadLine();


            //7.Create a custom exception class named FileTooLargeException which is thrown when a file 
            //        exceeds 1 MB in size.Write a program that reads a file's size and throws this exception if the file 
            //size is too large.Otherwise, it should display "File size is acceptable." 

            //string filePath = "largefile.txt";

            //try
            //{
            //    FileInfo fileInfo = new FileInfo(filePath);
            //    if (fileInfo.Length > 1024 * 1024) // 1 MB 
            //    {
            //        throw new FileTooLargeException("The file size exceeds the 1 MB limit.");
            //    }
            //    Console.WriteLine("File size is acceptable.");
            //}
            //catch (FileTooLargeException ex)
            //{
            //    Console.WriteLine("Custom Exception: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //}
            //Console.ReadLine();

            //8.Define a Book class with properties Title, Author, and ISBN. Write a program that serializes an 
            //instance of Book to an XML file named "book.xml" and then deserializes it back, displaying the
            //details on the console.

            //Book book = new Book
            //{
            //    Title = "C# Programming",
            //    Author = "John Doe",
            //    ISBN = "1234567890"
            //};
            //string filePath = "book.xml";

            //// Serialize to XML 
            //XmlSerializer serializer = new XmlSerializer(typeof(Book));
            //using (FileStream fs = new FileStream(filePath, FileMode.Create))
            //{
            //    serializer.Serialize(fs, book);
            //}
            //Console.WriteLine("Book object serialized to XML.");

            //// Deserialize from XML 
            //Book deserializedBook;
            //using (FileStream fs = new FileStream(filePath, FileMode.Open))
            //{
            //    deserializedBook = (Book)serializer.Deserialize(fs);
            //}
            //Console.WriteLine($"Title: {deserializedBook.Title}, Author: {deserializedBook.Author}, ISBN: {deserializedBook.ISBN} ");
            //Console.ReadLine();

        }

    }


}

