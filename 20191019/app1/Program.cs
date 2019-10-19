using System;

namespace app1
{
    class Program
    {
        static int Sum(int a, int b, int c)
        {
            int total;
            total = a+b+c;
            return total;
        }
        static void Main(string[] args)
        {
            int result;
            result = Sum(10, 20, 30);
            Console.WriteLine(result);
        }
    }
}
