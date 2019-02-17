using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Sum(int a, ref int b, out int c)
        {
            a++;
            b++;
            c = 100;
            return a + b + c;
        } 
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int z;
            int ans = Sum(x,ref y, out z);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
