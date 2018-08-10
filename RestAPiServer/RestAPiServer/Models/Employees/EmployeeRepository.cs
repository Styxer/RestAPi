using RestAPiServer.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.WorkPackagess
{
    public class EmployeeRepository : IRepository<Employees>
    {
        private List<Employees> employees = new List<Employees>();
        private int _nextId = 1;

        public EmployeeRepository()
        {
            Add(new Employees
            {
                FirstName = "Han",
                LastName = "Solo",
                employeeType = EmployeeType.pilot
                ,
                DOB = new DateTime(year: 1942, month: 6, day: 13)
            });


            Add(new Employees
            {
                FirstName = "Leia",
                LastName = "Organa",
                employeeType = EmployeeType.engineer
                ,
                DOB = new DateTime(year: 1956, month: 10, day: 21)
            });

            Add(new Employees
            {
                FirstName = "Mace",
                LastName = "Windu",
                employeeType = EmployeeType.jedi
              ,
                DOB = new DateTime(year: 1948, month: 12, day: 21)
            });
            

        }

        public Employees Add(Employees item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item WorkPackages");
            }

            item.Id = _nextId++;
            employees.Add(item);
            return item;
        }

        public Employees Get(int id)
        {
            return employees.Find(p => p.Id == id);
        }

        public IEnumerable<Employees> GetAll()
        {
            return employees;
        }

        public void Remove(int id)
        {
            employees.RemoveAll(p => p.Id == id);
        }

        public bool Update(Employees item)
        {
            var result = true;
            if (item == null)    //no item        
                throw new ArgumentNullException("item");
            
            int index = employees.FindIndex(p => p.Id == item.Id);
            if (index == -1)   //item not found         
                result = false;
            
            employees.RemoveAt(index);
            employees.Add(item);
            return result;
        }
    }
}