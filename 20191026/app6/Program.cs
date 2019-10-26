using System;

namespace app6
{
    class Program
    {
        static void Show(int[] obj)
        {
            foreach(int no in obj)
            {
                Console.Write($"{no}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] data = {21, 35, 12, 8, 6, 99, 19};
            Show(data);
        }
    }
}
