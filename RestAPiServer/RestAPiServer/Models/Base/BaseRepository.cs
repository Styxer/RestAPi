using RestAPiServer.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Base
{
    public class BaseRepository<T> : IRepository<T>  where T: BaseModel 
    {
        private IEnumerable<T> listData;
        private List<Customers> customers = new List<Customers>();

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
        }
  

        public IEnumerable<T> GetAll(List<T> listData)
        {
            return listData;
        }

        public T Get(int id, List<T> listData)
        {
            return listData.Find(p => p.Id == id);
        }

        public T Add(T item, List<T> listData)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item Customers");
            }
         
           // item.Id = _nextId++;
            listData.Add(item);//// ......
            return item;
        }

        public void Remove(int id, List<T> listData)
        {
            listData.RemoveAll(p => p.Id == id);
        }

        public bool Update(T item, List<T> listData)
        {
            var result = true;
            if (item == null)    //no item        
                throw new ArgumentNullException("item");

            int index = listData.FindIndex(p => p.Id == item.Id);
            if (index == -1)   //item not found         
                result = false;

            listData.RemoveAt(index);
            listData.Add(item);
            return result;
        }

      
    }
}