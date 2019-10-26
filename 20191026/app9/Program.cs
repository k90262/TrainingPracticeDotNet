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
            select p; 

            foreach(var p in result)
            {
                Console.WriteLine($"{p.ProcessName}.exe\t{p.WorkingSet64}");
            }


        }
    }
}
