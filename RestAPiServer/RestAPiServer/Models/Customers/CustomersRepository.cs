using RestAPiServer.Models.Base;
using RestAPiServer.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Customerss
{
    public class CustomersRepository : IRepository<Customer>
    {
        private List<Customer> customers = new List<Customer>();
        private BaseRepository<Customer> baseRepository = new BaseRepository<Customer>();
        private int _nextId = 1;

        public CustomersRepository()
        {
            Add(new Customer { CustName = "Han solo" });
            Add(new Customer { CustName = "Princess Lea" });
            Add(new Customer { CustName = "Chewi"});
           
        }

        public Customer Add(Customer item, List<Customer> listData = null)
        {
            item.Id = _nextId++;
            return baseRepository.Add(item, customers);
        }

        public Customer Get(int id, List<Customer> listData = null)
        {
            return baseRepository.Get(id, customers);
        }

        public IEnumerable<Customer> GetAll(List<Customer> listData = null)
        {
            return baseRepository.GetAll(customers);
        }

        public void Remove(int id, List<Customer> listData= null)
        {
             baseRepository.Remove(id, customers);
        }

        public bool Update(Customer item, List<Customer> listData = null)
        {
           return baseRepository.Update(item, customers);
        }
    }
}