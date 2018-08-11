using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPiServer.Models.Projects
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll(List<T> listData);
        T Get(int id, List<T> listData);
        T Add(T item, List<T> listData);      
        void Remove(int id, List<T> listData);
        bool Update(T item, List<T> listData);
    }
}
