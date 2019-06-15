using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Demo
    {
        public string CustomerName { get; set; }
        public DateTime? CustomerBirthday { get; set; }
        public string ProductName { get; set; }
        public decimal ListPrice { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
    }
}