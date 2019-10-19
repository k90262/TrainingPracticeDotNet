using System;

namespace app1
{
    class Program
    {
        static int Sum(int a, ref int b, out int c, ref int[] args) // in, in/out, out
        {
            a = 1;
            b = 2;
            c = 3;
            args[0] = args[1] + args[2];
            int total;
            total = a+b+c;
            return total;
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z;
            int[] data = {1, 2, 3};
            int result;
            result = Sum(x, ref y, out z, ref data); // ref type: 可加ref可不加
            Console.WriteLine(result);
            Console.WriteLine($"x={x}, y={y}, z={z}");
            Console.WriteLine($"data[0]={data[0]}");
        }
    }
}
