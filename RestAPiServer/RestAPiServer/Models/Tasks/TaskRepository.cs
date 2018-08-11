//using RestAPiServer.Models.Projects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace RestAPiServer.Models.WorkPackagess
//{
//    public class TaskRepository : IRepository<Task>
//    {
//        private List<Task> WorkPackagess = new List<Task>();
//        ProjectRepository project = new ProjectRepository();
//        private int _nextId = 1;

//        public TaskRepository()
//        {
//            Add(new Task { taskName = "paint the death start", project = project.Get(1) });
//            Add(new Task { taskName = "gather metrials", project = project.Get(1) });
//            Add(new Task { taskName = "paint the Millennium falcon", project = project.Get(2) });
//            Add(new Task { taskName = "paint the droids", project = project.Get(3) });
//        }
//        public Task Add(Task item)
//        {
//            if (item == null)
//            {
//                throw new ArgumentNullException("item WorkPackages");
//            }

//            item.Id = _nextId++;
//            WorkPackagess.Add(item);
//            return item;
//        }

//        public Task Get(int id)
//        {
//            return WorkPackagess.Find(p => p.Id == id);
//        }

//        public IEnumerable<Task> GetAll()
//        {
//            return WorkPackagess;
//        }

//        public void Remove(int id)
//        {
//            WorkPackagess.RemoveAll(p => p.Id == id);
//        }

//        public bool Update(Task item)
//        {
//            var result = true;
//            if (item == null)    //no item        
//                throw new ArgumentNullException("item");
            
//            int index = WorkPackagess.FindIndex(p => p.Id == item.Id);
//            if (index == -1)   //item not found         
//                result = false;
            
//            WorkPackagess.RemoveAt(index);
//            WorkPackagess.Add(item);
//            return result;
//        }
//    }
//}