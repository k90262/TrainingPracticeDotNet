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
            Console.Write("Enter an key to call web api ...");
            Console.ReadKey();

            WebClient client = new WebClient();
            client.BaseAddress = "http://localhost:1856";
            string s = client.DownloadString("/api/Customers");
            //Console.WriteLine(s);

            //var result = (JArray)JsonConvert.DeserializeObject(s);
            //Console.Write(result.Count.ToString());
            var result = JsonConvert.DeserializeObject<Customer[]>(s);
            foreach (Customer c in result)
            {
                Console.WriteLine("{0}\t{1}\t{2}", c.CustomerID, c.Name, c.Birthday);
            }

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
