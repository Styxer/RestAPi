using RestAPiServer.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Projects
{
    public class ProjectRepository : IRepository<Project>
    {
        private List<Project> projects = new List<Project>();
        private BaseRepository<Project> baseRepository = new BaseRepository<Project>();
        private int _nextId = 1;

        public ProjectRepository()
        {
            Add(new Project { ProjectName = "build the death start", Tariff = 10.2, customer = new Customer() { CustName= "f", Id =2} }, projects);
          //  Add(new Project { ProjectName = "find the Millennium falcon", CustName = "Han solo", CustId = 2, Tariff = 66.7 }, projects);
          //  Add(new Project { ProjectName = "look for the druids", CustName = "Clone trooper", CustId = 3, Tariff = 104.2 } , projects);
            //Add(new Project { Name = "Hammer", Category = "Hardware", Price = 16.99M });
        }

        public Project Add(Project item, List<Project> listData)
        {
            return baseRepository.Add(item, projects);
        }

        public Project Get(int id, List<Project> listData)
        {
            return baseRepository.Get(id, projects);
        }

        public IEnumerable<Project> GetAll(List<Project> listData)
        {
            return baseRepository.GetAll(projects);
        }

        public void Remove(int id, List<Project> listData)
        {
            baseRepository.Remove(id, projects);
        }

        public bool Update(Project item, List<Project> listData)
        {
            return baseRepository.Update(item, projects);
        }
    }
}