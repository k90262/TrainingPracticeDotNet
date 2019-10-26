using System;
using System.IO;
using System.Text;

namespace app10
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "BBC中文網是面向全球華人並每日更新的新聞資訊網站，提供客觀及時和凖確的內容以及對新聞故事的深入分析和評論。我們也提供繁體版臉書。";
            byte[] buffer = Encoding.UTF7.GetBytes(s);
            FileStream fs = new FileStream(@"C:\Demos\test.txt", FileMode.Create);
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();
            Console.WriteLine("OK");
        }
    }
}
