using RestAPiServer.Controllers.Base;
using RestAPiServer.Models.Customerss;
using RestAPiServer.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPiServer.Controllers
{
    public class CustomersController : ApiController
    {

        static readonly IRepository<Customer> repo = new CustomersRepository();
        static readonly BaseController<Customer> baseRepo = new BaseController<Customer>();
        // GET: api/Customers
        public IEnumerable<Customer> Get()
        {
            return baseRepo.Get(repo);
        }



        // POST: api/Customers
        public HttpResponseMessage Post(Customer item)
        {
            return baseRepo.Post(item, repo);
        }

        // PUT: api/Customers/5
        public void Put(int id, Customer product)
        {
            baseRepo.Put(id, product, repo);
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
            baseRepo.Delete(id, repo);
        }
    }
}
