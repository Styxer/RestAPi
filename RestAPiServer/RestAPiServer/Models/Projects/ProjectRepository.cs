using RestAPiServer.Models.Base;
using RestAPiServer.Models.Customerss;
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
        IRepository<Customer> customer = new CustomersRepository();
        private int _nextId = 1;

        public ProjectRepository()
        {
            Add(new Project { ProjectName = "build the death start", Tariff = 10.2, Customer = customer.Get(1) });
            Add(new Project { ProjectName = "find the Millennium falcon", Tariff = 66.7, Customer = customer.Get(1) });
            Add(new Project { ProjectName = "look for the druids",  Tariff = 104.2, Customer = customer.Get(2) });
            Add(new Project { ProjectName = "do the Hammer Time", Tariff = 16.99, Customer = customer.Get(3) });
        }

        public Project Add(Project item, List<Project> listData = null, int nextID = 1)
        {
            return baseRepository.Add(item, projects, _nextId);
        }

        public Project Get(int id, List<Project> listData = null)
        {
            return baseRepository.Get(id, projects);
        }

        public IEnumerable<Project> GetAll(List<Project> listData = null)
        {
            return baseRepository.GetAll(projects);
        }

        public void Remove(int id, List<Project> listData = null)
        {
            baseRepository.Remove(id, projects);
        }

        public bool Update(Project item, List<Project> listData  = null)
        {
            return baseRepository.Update(item, projects);
        }
    }
}