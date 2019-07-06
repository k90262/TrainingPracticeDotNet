using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an key to call web api ...");
            Console.ReadKey();

            WebClient client = new WebClient();
            client.BaseAddress = "http://localhost:1856";
            string s = client.DownloadString("/api/Customers");
            //Console.WriteLine(s);

            /*** JSON to obj ***/
            //var result = (JArray)JsonConvert.DeserializeObject(s);
            //Console.Write(result.Count.ToString());

            /** to Strong type method**/
            //var result = JsonConvert.DeserializeObject<Customer[]>(s);
            //foreach (Customer c in result)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}", c.CustomerID, c.Name, c.Birthday);
            //}

            /** to Weak type mehtod **/
            //dynamic result = JArray.Parse(s).Cast<dynamic>().ToArray();
            var result = JArray.Parse(s);
            foreach (dynamic c in result)
            {
                Console.WriteLine("{0}\t{1}\t{2}", c.CustomerID, c.Name, c.Birthday);
            }

            /*** obj to JSON ***/
            var obj1 = new Customer();
            obj1.CustomerID = 11;
            obj1.Name = "Cola";
            obj1.Birthday = DateTime.Parse("1980/8/1");

            var jo = JObject.FromObject(obj1);
            Console.WriteLine(jo.ToString());
            Console.ReadKey();
        }
    }

    class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
