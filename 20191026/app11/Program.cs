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
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            fs.Close();
            string s = Encoding.UTF7.GetString(buffer);
            Console.WriteLine(s);
        }
    }
}
