using RestAPiServer.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Base
{
    public class BaseRepository<T> : IRepository<T>
    {
        private List<T> customers = new List<T>();

        private int _nextId = 0;
        // private int _nextId = 1;

        public enum RepoType
        {
            Projects,
            Employees,
            Tasks,
            Work_Packages,
            Customers
        }

        public BaseRepository()
        {
            _nextId = 0;
            //if (dataType == RepoType.Projects)
            //    initProjectsData();
            //else if (dataType == RepoType.Employees)
            //    initProjectsData();
        }

        //private void initProjectsData()
        //{
        //    Add(new Project { ProjectName = "build the death start", CustName = "Lord vader", CustId = 1, Tariff = 10.2 });
        //    Add(new Project { ProjectName = "find the Millennium falcon", CustName = "Han solo", CustId = 2, Tariff = 66.7 });
        //    Add(new Project { ProjectName = "look for the druids", CustName = "Clone trooper", CustId = 3, Tariff = 104.2 });
        //}

        //private void Add(Project project)
        //{
        //    throw new NotImplementedException();
        //}

        //private void initCustomersData()
        //{
        //    Add(new Customers { CustName = "Han solo" });
        //    Add(new Customers { CustName = "Princess Lea" });
        //    Add(new Customers { CustName = "Chewi" });
        //}

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();

        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public T Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item Customers");
            }
         
           // item.Id = _nextId++;
            customers.Add(item);//// ......
            return item;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T item)
        {
            throw new NotImplementedException();
        }

      
    }
}