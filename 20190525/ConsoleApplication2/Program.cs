using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Database2Container();

            foreach(var score in db.Scores)
            {
                Console.WriteLine("{0}\t{1}\t{2}", score.Student.Name, score.Course.Name, score.Value);
            }

            Console.ReadKey();

        }
    }
}
