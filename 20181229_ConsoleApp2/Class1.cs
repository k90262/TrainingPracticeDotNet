using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181229_ConsoleApp2

{
    public static class Class1
    {
        public static void Show(this int no)
        {
            Console.WriteLine(no);
        }

        public static int Double(this int no)
        {
           return no * 2;
        }

        public static int Mul(this int no, int no2)
        {
            return no * no2;
        }

        public static void Show(this IEnumerable data)
        {
            string s = "";
            foreach (int no in data) {
                //s += no.ToString() + ",\n";
                s += string.Format("{0 }, ", no); 
            }
            Console.WriteLine(s);
        }
    }
}
