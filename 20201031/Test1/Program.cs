using System;
using System.Linq;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = {23, 10, 5, 97, 55, 34, 45};

            // LINQ
            var result =
                from no in data
                select no;

            foreach (var obj in result)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
