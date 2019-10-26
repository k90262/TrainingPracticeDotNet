using System;
using System.IO;

namespace app13
{
    class Program
    {
        static void Main(string[] args)
        {
                        // Read and Coy to a new file
            File.Copy(@"C:\Demos\test.txt", @"C:\Demos\test2.txt", true);
            Console.WriteLine("OK");
        }
    }
}
