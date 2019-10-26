using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace app6
{
    class Program
    {
        static void Show(IEnumerable<int> obj)
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
            //Show(data);
            data.Show();

            var result = from no in data // forech
                where no >= 30 // if
                orderby no descending  // sort
                select no; // choose
            //Show(result);
            result.Show();
        }
    }
}
