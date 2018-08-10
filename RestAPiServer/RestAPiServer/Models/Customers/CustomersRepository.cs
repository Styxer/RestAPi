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

        public Customers Add(Customers item)
        {
           return baseRepository.Add(item);
        //    if (item == null)
        //    {
        //        throw new ArgumentNullException("item Customers");
        //    }

            //    item.Id = _nextId++;
            //    customers.Add(item);
            //    return item;
        }

       

        public Customers Get(int id)
        {
            return customers.Find(p => p.Id == id);
        }


        public IEnumerable<Customers> GetAll()
        {
            return customers;
        }

        public void Remove(int id)
        {
            customers.RemoveAll(p => p.Id == id);
        }

        public bool Update(Customers item)
        {
            var result = true;
            if (item == null)    //no item        
                throw new ArgumentNullException("item");
            
            int index = customers.FindIndex(p => p.Id == item.Id);
            if (index == -1)   //item not found         
                result = false;
            
            customers.RemoveAt(index);
            customers.Add(item);
            return result;
        }
    }
}