using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //static int Sum(int a, int b=0, int c=0)
        static int Sum(params int[] data)
        {
            int total = 0;
            for (int i = 0; i < data.GetLength(0); i++)
                total += data[i];
            return total ;
        }

        static void Main(string[] args)
        {
            //int ans = Sum(1,c:3);
            int ans = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
