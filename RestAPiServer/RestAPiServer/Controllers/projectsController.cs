using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestAPiServer.Models.Projects;
using RestAPiServer.Controllers.Base;

namespace RestAPiServer.Controllers
{
    public class ProjectsController : ApiController
    {

        static readonly IRepository<Project> repo = new ProjectRepository();
        static readonly BaseController<Project> baseRepo = new BaseController<Project>();

        // GET: api/projects
        public IEnumerable<Project> Get()
        {
            //return repo.GetAll();
           return baseRepo.Get(repo);
        }

       
        public HttpResponseMessage Post(Project item)
        {
            return baseRepo.Post(item, repo);
          
        }

        // PUT: api/projects/5
        public void Put(int id, Project item)
        {
            baseRepo.Put(id, item, repo);
           
        }

        // DELETE: api/projects/5
        public void Delete(int id)
        {       
            baseRepo.Delete(id, repo);
        }
    }
}
