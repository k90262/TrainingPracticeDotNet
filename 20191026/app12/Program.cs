using System;
using System.IO;
using System.Text;

namespace app12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read and Coy to a new file
            FileStream fs = new FileStream(@"C:\Demos\test.txt", FileMode.Open);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            fs.Close();

            FileStream fs2 = new FileStream(@"C:\Demos\test2.txt", FileMode.Create);
            fs2.Write(buffer, 0, buffer.Length);
            fs2.Close();
            Console.WriteLine("OK");
        }
    }
}
