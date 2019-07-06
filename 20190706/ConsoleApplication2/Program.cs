using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = new JObject();
            obj.Name = "Lusy";
            obj.Birthday = DateTime.Parse("2000/1/1");
            Console.WriteLine(obj.ToString());

            WebClient client = new WebClient();
            client.BaseAddress = "http://localhost:1856";
            client.Headers.Add("Content-Type", "application/json");
            string s = client.UploadString("/api/Customers","POST" , obj.ToString());
            Console.WriteLine(s);

            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
