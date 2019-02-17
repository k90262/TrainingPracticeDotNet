using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void MySort(int[] obj, Func<int, int, bool> f)
        {
            for(int i=0;i<obj.GetUpperBound(0);i++)
                for(int j=i+1;j<=obj.GetUpperBound(0);j++)
                    if (f.Invoke(obj[j], obj[i]))
                    {
                        int tmp = obj[i];
                        obj[i] = obj[j];
                        obj[j] = tmp;
                    }
        }

        static void Main(string[] args)
        {
            int[] data = { 15, 34, 65, 23, 45,  56, 88, 47, 79, 52 };
            MySort(data, (a, b) => {
                if (a % 2 == 1 && b % 2 == 0)
                    return true;
                else if (a % 2 == 1 && b % 2 == 1)
                    return a < b;
                else if (a % 2 == 0 && b % 2 == 0)
                    return a > b;
                else
                    return false;
            });

            Console.ReadKey();
        }
    }
}
