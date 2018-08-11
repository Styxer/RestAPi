using RestAPiServer.Models;
using RestAPiServer.Models.Base;
using RestAPiServer.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace RestAPiServer.Controllers.Base
{
    public class BaseController<T> : ApiController where T : BaseModel
    {
        List<T> dataList;

        private void setRepo(Repos.RepoType repoType)
        {
           //if (_repo == null)
           // {
           //     if (repoType == Repos.RepoType.Projects)
           //         _repo = new ProjectRepository();
           // }
        }



        public void Delete(int id, IRepository<T> repo)
        {
            repo.Remove(id, dataList);
        }

        public  IEnumerable<T> Get(IRepository<T> repo)
        {
            return repo.GetAll(dataList);
        }

        public HttpResponseMessage Post(T item, IRepository<T> repo)
        {
            item = repo.Add(item, dataList);
            var response = Request.CreateResponse<T>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void Put(int id, T product, IRepository<T> repo)
        {
            product.Id = id;
            if (!repo.Update(product, dataList))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
    }
}