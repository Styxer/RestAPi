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

        // GET: api/Customers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
        }
    }
}
