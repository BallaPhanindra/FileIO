using System;
using System.Collections.Generic;
using System.IO;

namespace FileIO
{
   public class Program
    {
        Address address1 = new Address("Balla", "Phanindra", "Prahsnath Nagar", "Siddipet",
            "TS", "502103", 9876543210, "pha@gmail.com");

        static void Main(string[] args)
        {
            Program.FileExists();
            Program.ReadAllLines();
            Program.ReadAllText();
            Program.DeleteFile();
            Program.CopyFile();
        }
    public static void FileExists()
        {
            String path = "D:/BridgeLabz/FileIO/test.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
}
        public static void ReadAllLines()
        {
            String path = "D:/BridgeLabz/FileIO/test.txt";
            String[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            String path = "D:/BridgeLabz/FileIO/test.txt";
            String lines;
            lines= File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        public static void DeleteFile()
        {
            String path = @"D:/BridgeLabz/FileIO/test1.txt";
            File.Delete(path);
            if (File.Exists(path))
            {
                Console.WriteLine("File not deleted");
            }
            else
            {
                Console.WriteLine("File deleted");
            }
        }
        public static void CopyFile()
        {
            String path = @"D:/BridgeLabz/FileIO";
            String copyPath = @"D:/";
        
            File.Copy(path, copyPath);
            Console.ReadKey();
        }

    }
}
