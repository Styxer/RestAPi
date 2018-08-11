using RestAPiServer.Models.Base;
using RestAPiServer.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.WorkPackagess
{
    public class WorkPackagesRepository : IRepository<WorkPackage>
    {
        private List<WorkPackage> workPackagess = new List<WorkPackage>();
        IRepository<Employe> employe = new EmployeRepository();
        IRepository<Task> task = new TaskRepository();
        private BaseRepository<WorkPackage> baseRepository = new BaseRepository<WorkPackage>();
        private int _nextId = 1;

        public WorkPackagesRepository()
        {
            Add(new WorkPackage { StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(3), employee = employe.Get(1), task = task.Get(1) });
            Add(new WorkPackage { StartTime = DateTime.Now.AddDays(10), EndTime = DateTime.Now.AddDays(30), employee = employe.Get(2), task = task.Get(2) });
            Add(new WorkPackage { StartTime = DateTime.Now.AddDays(15), EndTime = DateTime.Now.AddDays(35), employee = employe.Get(3), task = task.Get(3) });

        }

        public WorkPackage Add(WorkPackage item, List<WorkPackage> listData = null, int nextID = 1)
        {
            return baseRepository.Add(item, workPackagess, _nextId);
        }

        public WorkPackage Get(int id, List<WorkPackage> listData = null)
        {
            return baseRepository.Get(id, workPackagess);
        }

        public IEnumerable<WorkPackage> GetAll(List<WorkPackage> listData = null)
        {
            return baseRepository.GetAll(workPackagess);
        }

        public void Remove(int id, List<WorkPackage> listData = null)
        {
            baseRepository.Remove(id, workPackagess);
        }

        public bool Update(WorkPackage item, List<WorkPackage> listData = null)
        {
            return baseRepository.Update(item, workPackagess);
        }
    }
}