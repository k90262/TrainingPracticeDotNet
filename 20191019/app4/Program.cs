using System;
using System.Threading.Tasks;

namespace app4
{
    class Program
    {
        static int M1(int no)
        {
            int result = no * 2;
            Console.WriteLine(result);
            return result;
        }
        static int M2(int no)
        {
            int result = no * 4;
            Console.WriteLine(result);
            return result;
        }
        static int M3(int no)
        {
            int result = no * 8;
            Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            int no = 5;
            //int no1 = M1(no);  // sync
            // Func<int, int> f1 = M1;
            // int no1 = f1.Invoke(no); // sync
            Task t1 = Task.Run(() =>
            {    // asyc
                int no1 = M1(no);

                Task t2 = Task.Run(() =>
                {    // asyc
                    int no2 = M2(no1);

                    Task t3 = Task.Run(() =>
                    {    // asyc
                        int no3 = M3(no2);
                        Console.WriteLine("M3 OK!");
                    });

                    Console.WriteLine("M2 OK!");
                });

                Console.WriteLine("M1 OK!");
            });

            //int no2 = M2(no);  // sync
            //Func<int, int> f2 = M2;
            //int no2 = f2.Invoke(no);  // sync            


            //int no3 = M3(no);  // sync
            //Func<int, int> f3 = M3;
            //int no3 = f3(no); // it's also ok
            //int no3 = f3.Invoke(no);  // sync

            Console.ReadKey();
        }
    }
}
