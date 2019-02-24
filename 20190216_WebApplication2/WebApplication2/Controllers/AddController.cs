using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class AddController : ApiController
    {
        public int Get(int no1, int no2)
        {
            return no1 + no2;
        }
    }
}
