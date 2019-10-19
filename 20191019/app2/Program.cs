using System;

namespace app2
{
    class Program
    {
        static int Sum(params int[] data)
        {
            int total = 0;
            foreach (int no in data)
                total += no;
            return total;
        }
        static void Main(string[] args)
        {
            int result = Sum(10, 20, 30, 40, 50, 1, 2, 3, 4, 5);
            Console.WriteLine(result);
        }
    }
}
