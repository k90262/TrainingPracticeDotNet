using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public IEnumerable<Customer> Get()
        {
            return db.Customers;
        }

        public Customer Get(int id)
        {
            Customer obj = db.Customers.Find(id);
            if (obj != null)
                return obj;
            else
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        public Customer Post(Customer obj)
        {
            db.Customers.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public Customer Put(int id,Customer obj)
        {
            obj.CustomerId = id;
            db.Entry(obj).State=EntityState.Modified;
            db.SaveChanges();
            return obj;

        }

    }
}
