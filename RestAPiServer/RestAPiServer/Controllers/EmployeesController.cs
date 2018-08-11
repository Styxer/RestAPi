using RestAPiServer.Controllers.Base;
using RestAPiServer.Models.Projects;
using RestAPiServer.Models.WorkPackagess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPiServer.Controllers
{
    public class EmployeesController : ApiController
    {

        static readonly IRepository<Employe> repo = new EmployeRepository();
        static readonly BaseController<Employe> baseRepo = new BaseController<Employe>();

        // GET: api/Employees
        public IEnumerable<Employe> Get()
        {
           return baseRepo.Get(repo);
        }



        // POST: api/Employees
        public HttpResponseMessage Post(Employe item)
        {
            return baseRepo.Post(item, repo);
        }

        // PUT: api/Employees/5
        public void Put(int id, Employe product)
        {
            baseRepo.Put(id, product, repo);
        }

        // DELETE: api/Employees/5
        public void Delete(int id)
        {
            baseRepo.Delete(id, repo);
        }
    }
}
