using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Projects
{
    public class ProjectRepository : IRepository<Project>
    {
        private List<Project> projects = new List<Project>();
        private int _nextId = 1;

        public ProjectRepository()
        {
            Add(new Project { ProjectName = "build the death start", CustName = "Lord vader" , CustId = 1, Tariff = 10.2 });
            Add(new Project { ProjectName = "find the Millennium falcon", CustName = "Han solo", CustId = 2, Tariff = 66.7 });
            Add(new Project { ProjectName = "look for the druids", CustName = "Clone trooper", CustId = 3, Tariff = 104.2 });
            //Add(new Project { Name = "Hammer", Category = "Hardware", Price = 16.99M });
        }

        public Project Get(int id)
        {
            return projects.Find(p => p.Id == id);
        }

        public Project Add(Project item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item Project");
            }

            item.Id = _nextId++;
            projects.Add(item);
            return item;
        }

        public IEnumerable<Project> GetAll()
        {
            return projects;
        }

        public void Remove(int id)
        {
            projects.RemoveAll(p => p.Id == id);
        }

        public bool Update(Project item)
        {
            var result = true;
            if (item == null)    //no item        
                throw new ArgumentNullException("item");
            
            int index = projects.FindIndex(p => p.Id == item.Id);
            if (index == -1)   //item not found         
                result = false;
            
            projects.RemoveAt(index);
            projects.Add(item);
            return result;
        }
    }
}