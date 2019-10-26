using System;

namespace app8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = {21, 35, 12, 8, 6, 99, 19};
            data.Show();

            Array.Sort(data, new Comparer());
            data.Show();
        }
    }
}
