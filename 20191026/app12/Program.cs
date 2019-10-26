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
            FileStream fs2 = new FileStream(@"C:\Demos\test2.txt", FileMode.Create);
            fs.CopyTo(fs2);
            fs2.Close();
            fs.Close();
            Console.WriteLine("OK");
        }
    }
}
