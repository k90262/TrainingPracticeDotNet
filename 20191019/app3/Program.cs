using System;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] data = new int[10];
            // int[] data = new int[4] {10, 20, 30 ,40};
            // int[] data = new int[] {10, 20, 30 ,40};
            int[] data = {1, 2, 3 ,4, 5, 6, 7, 8, 9, 10};
            foreach(int no in data)
            {
                Console.WriteLine(no);
            }
        }
    }
}
