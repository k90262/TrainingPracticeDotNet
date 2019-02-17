using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181229_ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 21, 32, 55, 76, 89, 33, 53, 87, 98, 14, 44 };
            data.Show();

            var result =
                from no in data
                where no % 2 == 0
                orderby no descending
                select no;
            result.Show();
            //int no1 = 10;
            ////no1.Show(12);
            //no1.Show();

            //int no2 = no1.Double();
            //no2.Show();

            //int no3 = no2.Mul(5);
            //no3.Show();

            Console.ReadKey();
        }
    }
}
