using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestAPiServer.Models.Projects;

namespace RestAPiServer.Controllers
{
    public class projectsController : ApiController
    {

        static readonly IRepository<Project> repo = new ProjectRepository();

        // GET: api/projects
        public IEnumerable<Project> Get()
        {
            return repo.GetAll();
        }

       
        public HttpResponseMessage Post(Project item)
        {
            item = repo.Add(item);
            var response = Request.CreateResponse<Project>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // PUT: api/projects/5
        public void Put(int id, Project product)
        {
            product.Id = id;
            if (!repo.Update(product))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // DELETE: api/projects/5
        public void Delete(int id)
        {
            repo.Remove(id);
        }
    }
}
