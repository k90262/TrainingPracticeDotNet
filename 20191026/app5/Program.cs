using System;
using System.Threading;
using System.Threading.Tasks;

namespace app5
{
    class Program
    {
        static Task<int> Add(int a, int b) 
        {
            return Task<int>.Run(()=>{
                Thread.Sleep(5000);
                return a+b;
            });
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            Task<int> t = Add(10, 20);
            t.Wait();
            Console.WriteLine($"answer={t.Result}");
        }
    }
}
