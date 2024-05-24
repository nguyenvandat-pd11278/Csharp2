using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.IO;
    class Program
    {
        static void Main()
        {
            string directoryPath = @"C:\Users\ACER\Desktop\Csharp2";
            string filename = "data.txt";
            string filePath = Path.Combine(directoryPath, filename);
            WriteDataToFile(filePath);
            ReadDataFromFile(filePath);
        }
        static void WriteDataToFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs,Encoding.UTF8))
                {
                    sw.WriteLine("username : dat");
                    sw.WriteLine("passworld : 123");
                }
            }
        }
        static void ReadDataFromFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs,Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
    