using System;
using System.Threading;
using System.Threading.Tasks;

namespace app5
{
    class Program
    {

        static void Main(string[] args)
        {
            Test obj=new Test();
            obj.Go();
            Console.WriteLine("OK");
            Console.ReadKey();
            Console.WriteLine("Finished");
        }
    }
}
