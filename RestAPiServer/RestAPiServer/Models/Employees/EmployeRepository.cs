using RestAPiServer.Models.Base;
using RestAPiServer.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.WorkPackagess
{
    public class EmployeRepository : IRepository<Employe>
    {
        private List<Employe> employees = new List<Employe>();
        private BaseRepository<Employe> baseRepository = new BaseRepository<Employe>();
        private int _nextId = 1;

        public EmployeRepository()
        {
            Add(new Employe
            {
                FirstName = "Han",
                LastName = "Solo",
                employeeType = EmployeeType.pilot
                ,
                DOB = new DateTime(year: 1942, month: 6, day: 13)
            });


            Add(new Employe
            {
                FirstName = "Leia",
                LastName = "Organa",
                employeeType = EmployeeType.engineer
                ,
                DOB = new DateTime(year: 1956, month: 10, day: 21)
            });

            Add(new Employe
            {
                FirstName = "Mace",
                LastName = "Windu",
                employeeType = EmployeeType.jedi
              ,
                DOB = new DateTime(year: 1948, month: 12, day: 21)
            });


        }

        public Employe Add(Employe item, List<Employe> listData = null, int nextID = 0)
        {
           return  baseRepository.Add(item, employees, nextID);
        }

        public Employe Get(int id, List<Employe> listData = null)
        {
            return baseRepository.Get(id, employees);
        }

        public IEnumerable<Employe> GetAll(List<Employe> listData= null)
        {
            return baseRepository.GetAll(employees);
        }

        public void Remove(int id, List<Employe> listData = null)
        {
            baseRepository.Remove(id, employees);
        }

        public bool Update(Employe item, List<Employe> listData = null)
        {
            return baseRepository.Update(item, employees);
        }
    }
}