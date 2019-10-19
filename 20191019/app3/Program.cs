using System;
using System.Threading.Tasks;

namespace app3
{
    class Program
    {
        // static void Print(int no)
        // {
        //     Console.WriteLine(no);
        // }
        static void Main(string[] args)
        {
            // int[] data = new int[10];
            // int[] data = new int[4] {10, 20, 30 ,40};
            // int[] data = new int[] {10, 20, 30 ,40};
            int[] data = {1, 2, 3 ,4, 5, 6, 7, 8, 9, 10};

            // foreach(int no in data) // data 必須要有實作 IEnumberable
            // {
            //     Console.WriteLine(no);
            // }
            //for (int i=0; i < data.GetUpperBound(0); i++) 
            //for (int i=0; i < data.GetUpperBound(0); i+=2) 
            for (int i=data.GetUpperBound(0); i >= 0; i--) 
            {
                Console.WriteLine(data[i]);
            }

            // Parallel.ForEach<int>(data, Print);

            // Action<int> act = delegate(int no)
            // {
            //     Console.WriteLine(no);
            // };

            // Action<int> act = (int no) => 
            // {
            //     Console.WriteLine(no);
            // };

            // Action<int> act = (no) => 
            // {
            //     Console.WriteLine(no);
            // };
            
            // Action<int> act = ;
            // Parallel.ForEach<int>(data, act);

            // Parallel.ForEach<int>(data, no => 
            // {
            //     Console.WriteLine(no);
            // });

        }
    }
}
