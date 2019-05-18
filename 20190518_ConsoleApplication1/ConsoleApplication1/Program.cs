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

            // LINQ
            var result =
                from c in db.Customers
                select c;
            Console.WriteLine(result.ToString());
            foreach (var obj in result)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    obj.CustomerID,
                    obj.Name,
                    obj.Birthday
                );
            }

            // LINQ JOIN
            //var result =
            //    from c in db.Customers
            //    join o in db.Orders on c.CustomerID equals o.CustomerID
            //    join p in db.Products on o.ProductID equals p.ProductID
            //    where c.Birthday.Value.Month == 9
            //    select new { CustomerName = c.Name, ID = c.CustomerID, c.Birthday, ODate = o.OrderDate, PName = p.Name };
            //Console.WriteLine(result.ToString());
            //foreach (var obj in result)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
            //        obj.CustomerName,
            //        obj.ID,
            //        obj.Birthday,
            //        obj.ODate,
            //        obj.PName
            //    );
            //}

            // LINQ JOIN (other way)
            //var result =
            //    from c in db.Customers
            //    from o in c.Orders
            //    let p = o.Product
            //    where c.Birthday.Value.Month == 9
            //    select new { CustomerName = c.Name, ID = c.CustomerID, c.Birthday, ODate = o.OrderDate, PName = p.Name };
            //Console.WriteLine(result.ToString());
            //foreach (var obj in result)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
            //        obj.CustomerName,
            //        obj.ID,
            //        obj.Birthday,
            //        obj.ODate,
            //        obj.PName
            //    );
            //}

            // ADD
            //var obj = new Customer();
            //obj.Name = "Jackson";
            //obj.Birthday = new DateTime(2000, 5, 12);
            //db.Customers.Add(obj);
            //db.SaveChanges();

            // MODIFIED
            //var result = from c in db.Customers
            //             where c.Birthday.Value.Month == 8
            //             select c;
            //foreach (var obj in result) {
            //    obj.Birthday = new DateTime(obj.Birthday.Value.Year, 9, obj.Birthday.Value.Day);
            //}
            //db.SaveChanges();

            // DELETE
            //var result = from c in db.Customers
            //             where c.CustomerID == 3
            //             select c;
            //foreach (var obj in result)
            //{
            //    db.Customers.Remove(obj);
            //}
            //db.SaveChanges();

            // MODIFIED ver2 (better performance, without get data first)
            //var obj = new Customer();
            //obj.CustomerID = 4;
            //obj.Name = "Jackson 2";
            //obj.Birthday = new DateTime(2002, 2, 2);
            //db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();

            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
