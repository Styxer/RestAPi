using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPiServer.Models.Projects
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll(List<T> listData = null);
        T Get(int id, List<T> listData = null);
        T Add(T item, List<T> listData = null, int nextID  = 1);      
        void Remove(int id, List<T> listData = null);
        bool Update(T item, List<T> listData= null);
    }
}
