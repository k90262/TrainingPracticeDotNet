using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class BMIController : ApiController
    {
        public double Get(double height, double weight)
        {
            double h = height / 100;
            return Math.Round(weight / h / h, 2);
        }

    }
}
