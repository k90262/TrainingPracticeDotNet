using System;
using System.IO;
using System.Text;

namespace app11
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Demos\test.txt", FileMode.Open);

            fs.Close();
            Console.WriteLine("OK");
        }
    }
}
