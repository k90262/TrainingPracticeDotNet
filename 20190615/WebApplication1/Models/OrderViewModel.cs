using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public SelectList Customers { get; set; }
        public SelectList Products { get; set; }
        public decimal? Price { get; set; }
    }
}