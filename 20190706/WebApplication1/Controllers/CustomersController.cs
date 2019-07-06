﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomersController : ApiController
    {
        Database1Entities db = new Database1Entities();

        public CustomersController() {
            db.Configuration.ProxyCreationEnabled = false; // 確保丟回API時，不會依造表格關連線產生無限迴圈而無法序列化資料(Customers -> Orders -> Customers -> ....)
        }
        public IEnumerable<Customer> Get()
        {
           return db.Customers; 
        }
    }
}
