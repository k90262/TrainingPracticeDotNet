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
                where no % 2 == 1
                orderby no descending
                select no;

            var result2 = data.Where(no => no % 2 == 1).OrderByDescending(no => no);

            foreach (var obj in result)
            {
                Console.WriteLine(obj);
            }

            foreach (var obj in result2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
