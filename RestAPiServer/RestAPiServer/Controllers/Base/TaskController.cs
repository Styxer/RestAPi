using RestAPiServer.Models.Projects;
using RestAPiServer.Models.WorkPackagess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPiServer.Controllers.Base
{
    public class TaskController : ApiController
    {
        static readonly IRepository<Task> repo = new TaskRepository();
        static readonly BaseController<Task> baseRepo = new BaseController<Task>();
        // GET: api/Task
        public IEnumerable<Task> Get()
        {
            return baseRepo.Get(repo);
        }

        // POST: api/Task
        public HttpResponseMessage Post(Task item)
        {
            return baseRepo.Post(item, repo);
        }

        // PUT: api/Task/5
        public void Put(int id, Task item)
        {
            baseRepo.Put(id, item, repo);
        }

        // DELETE: api/Task/5
        public void Delete(int id)
        {
            baseRepo.Delete(id, repo);
        }
    }
}
