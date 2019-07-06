using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AddController : ApiController
    {
        public int Get(int no1, int no2) {
            return no1 + no2;
        }

        public int Get(int no1, int no2, int no3)
        {
            return no1 + no2 + no3;
        }

        public AddModel Post(AddModel obj) {
            obj.Ans = obj.No1 + obj.No2;
            return obj;
        }
    }
}
