using System.Linq;
using System.Diagnostics;
using System;

namespace app9
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = from p in Process.GetProcesses() 
            orderby p.WorkingSet64 descending
            select p; 
            //var result2 = result.Take(5) // 取前五個
            //                .Skip(3); // 省略前三個

            foreach(var p in result.Take(5))
            {
                Console.WriteLine($"{p.ProcessName}.exe\t{p.WorkingSet64}");
            }


        }
    }
}
