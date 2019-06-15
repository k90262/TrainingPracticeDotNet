using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Database1Entities();
            var result =
                from m in db.Members
                select m;

            Console.WriteLine(result.ToString());

            foreach (var m in result)
            {
                Console.WriteLine("{0}\t{1}\t{2}", m.Name.FirstName, m.Name.LastName, m.Name.FullName);
            }

            Member obj = new Member();
            obj.Name.FullName = "Michael Jackson";
            Console.WriteLine("{0}\t{1}", obj.Name.FirstName, obj.Name.LastName);
                
            Console.ReadKey();
        }
    }
}
