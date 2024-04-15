using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourcePath = @"D:\Visual\finalcontrol4\1.txt";
        string destinationPath = @"D:\Visual\finalcontrol4\2.txt";

        try
        {
            File.Copy(sourcePath, destinationPath, true);
            Console.WriteLine($"File copied from {sourcePath} to {destinationPath}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Source file not found. Please check the path.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error copying file: {ex.Message}");
        }
    }
}
