using System;
class Program
{
    static void Main()
    {
        string rootDirectory = @"C:\Users\ACER\Desktop\Csharp2";
        string dataDirectoryPath = Path.Combine(rootDirectory, "data");
        Directory.CreateDirectory(dataDirectoryPath);
        string dataFilePath = Path.Combine(dataDirectoryPath, "data.txt");
        using (StreamWriter sw = new StreamWriter(dataFilePath))
        {
            sw.WriteLine("MSVV : PD11278");
            sw.WriteLine("Ho va ten : Nguyen Van Dat");
        }
        string data2DirectoryPath = Path.Combine(rootDirectory, "data2");
        Directory.CreateDirectory(data2DirectoryPath);
        CopyFileRecursively(dataDirectoryPath, data2DirectoryPath);
    }
    static void CopyFileRecursively(string sourDir, string targetDir)
    {
        string[] files = Directory.GetFiles(sourDir);
        foreach (string file in files)
        {
            string fileName = Path.GetFileName(file);
            string destfile = Path.Combine(targetDir, fileName);
            File.Copy(file, destfile, true);
        }
        string[] subdirectories = Directory.GetDirectories(sourDir);
        foreach (string subdir in subdirectories)
        {
            string subdirName = Path.GetFileName(subdir);
            string destSubdir = Path.Combine(targetDir, subdirName);
            CopyFileRecursively (subdir, destSubdir);
        }
    }
}
