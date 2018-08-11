using RestAPiServer.Models.Base;
using RestAPiServer.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.WorkPackagess
{
    public class TaskRepository : IRepository<Task>
    {
        private List<Task> tasks = new List<Task>();
        IRepository<Project> project = new ProjectRepository();
        private BaseRepository<Task> baseRepository = new BaseRepository<Task>();
        private int _nextId = 1;

        public TaskRepository()
        {
            Add(new Task { TaskName = "paint the death start", project = project.Get(1) });
            Add(new Task { TaskName = "gather metrials", project = project.Get(1) });
            Add(new Task { TaskName = "paint the Millennium falcon", project = project.Get(2) });
            Add(new Task { TaskName = "paint the droids", project = project.Get(3) });
        }

        public Task Add(Task item, List<Task> listData = null, int nextID = 1)
        {
            return baseRepository.Add(item, tasks, _nextId);
        }

        public Task Get(int id, List<Task> listData = null)
        {
            return baseRepository.Get(id, tasks);
        }

        public IEnumerable<Task> GetAll(List<Task> listData = null)
        {
            return baseRepository.GetAll(tasks);
        }

        public void Remove(int id, List<Task> listData = null)
        {
             baseRepository.Remove(id, tasks);
        }

        public bool Update(Task item, List<Task> listData = null)
        {
            return baseRepository.Update(item, tasks);
        }
    }
}