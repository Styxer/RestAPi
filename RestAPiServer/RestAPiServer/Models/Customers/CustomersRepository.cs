using RestAPiServer.Models.Base;
using RestAPiServer.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Customerss
{
    public class CustomersRepository : IRepository<Customers>
    {
        private List<Customers> customers = new List<Customers>();
        private BaseRepository<Customers> baseRepository = new BaseRepository<Customers>();
        private int _nextId = 1;

        public CustomersRepository()
        {
            Add(new Customers { CustName = "Han solo" });
            Add(new Customers { CustName = "Princess Lea" });
            Add(new Customers { CustName = "Chewi"});
           
        }

        public Customers Add(Customers item, List<Customers> listData = null)
        {
           return baseRepository.Add(item, listData);
        }

        public Customers Get(int id, List<Customers> listData)
        {
            return baseRepository.Get(id, listData);
        }

        public IEnumerable<Customers> GetAll(List<Customers> listData)
        {
            return baseRepository.GetAll(listData);
        }

        public void Remove(int id, List<Customers> listData)
        {
             baseRepository.Remove(id, listData);
        }

        public bool Update(Customers item, List<Customers> listData)
        {
           return baseRepository.Update(item, listData);
        }
    }
}