using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataEntities();

            foreach (var obj in db.Cars)
            {

            }

            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
