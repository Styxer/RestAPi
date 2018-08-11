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
    public class WorkPackagesController : ApiController
    {
        static readonly IRepository<WorkPackage> repo = new WorkPackagesRepository();
        static readonly BaseController<WorkPackage> baseRepo = new BaseController<WorkPackage>();
        // GET: api/WorkPackages
        public IEnumerable<WorkPackage> Get()
        {
            return baseRepo.Get(repo);
        }

        // POST: api/WorkPackages
        public HttpResponseMessage Post(WorkPackage item)
        {
            return baseRepo.Post(item, repo);
        }

        // PUT: api/WorkPackages/5
        public void Put(int id, WorkPackage item)
        {
            baseRepo.Put(id, item, repo);
        }

        // DELETE: api/WorkPackages/5
        public void Delete(int id)
        {
            baseRepo.Delete(id, repo);
        }
    }
}
