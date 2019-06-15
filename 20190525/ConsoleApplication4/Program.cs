using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Database1Entities();

            foreach(var obj in db.Products.Take(2))
                Console.WriteLine("{0}\t{1}\t{2}", obj.ProductID, obj.Name, obj.Price);

            var ts = new TransactionScope();
            try
            {
                #region "Withdraw"
                var p1 = db.Products.Find(1);
                p1.Price--;
                db.SaveChanges();
                #endregion
                //throw new Exception("CRASH!");
                #region "Deposit"
                var p2 = db.Products.Find(2);
                p2.Price++;
                db.SaveChanges();
                #endregion
                ts.Complete();
            }
            catch
            {
                Console.WriteLine("TRANSACTION FAILED!");
                Console.ReadKey();
                return;
            }
            finally
            {
                ts.Dispose();
            }

            foreach (var obj in db.Products.Take(2))
                Console.WriteLine("{0}\t{1}\t{2}", obj.ProductID, obj.Name, obj.Price);


            Console.ReadKey();
        }
    }
}
