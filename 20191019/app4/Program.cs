using System;

namespace app4
{
    class Program
    {
        static int M1 (int no)
        {
            int result = no * 2;
            Console.WriteLine(result);
            return result;
        }
        static int M2 (int no)
        {
            int result = no * 4;
            Console.WriteLine(result);
            return result;
        }
        static int M3 (int no)
        {
            int result = no * 8;
            Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            int no = 5;
            int no1 = M1(no);
            Console.WriteLine("M1 OK!");
                        
            int no2 = M2(no);
            Console.WriteLine("M2 OK!");
            
            int no3 = M3(no);
            Console.WriteLine("M3 OK!");
        }
    }
}
