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
            var db = new Database1Entities1();
            //foreach (var obj in db.Orders)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", 
            //        obj.OrderID, 
            //        obj.OrderDate, 
            //        obj.Customer.Name, // many to one
            //        obj.Product.Name, 
            //        obj.Price, 
            //        obj.Quantity
            //    );
            //}

            //foreach (var c in db.Customers)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}",
            //        c.CustomerID,
            //        c.Name,
            //        c.Birthday
            //    );
            //    foreach (var o in c.Orders)  // one to many
            //    {
            //        Console.WriteLine("{0}\t{1}\t{2}",
            //            o.OrderID,
            //            o.CustomerID,
            //            o.ProductID
            //        );
            //    }
            //}

            var result = 
                from c in db.Customers
                where c.Birthday.Value.Month == 8
                select c;

            Console.WriteLine(result.ToString());

            foreach (var obj in result) {
                Console.WriteLine("{0}\t{1}\t{2}",
                    obj.CustomerID,
                    obj.Name,
                    obj.Birthday
                );
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
