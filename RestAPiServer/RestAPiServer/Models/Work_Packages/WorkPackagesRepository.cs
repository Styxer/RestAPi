//using RestAPiServer.Models.Projects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace RestAPiServer.Models.WorkPackagess
//{
//    public class WorkPackagesRepository : IRepository<WorkPackages>
//    {
//        private List<WorkPackages> WorkPackagess = new List<WorkPackages>();
//        private int _nextId = 1;

//        public WorkPackagesRepository()
//        {
//            Add(new WorkPackages { StartTime = DateTime.Now.AddDays(1) , EndTime = DateTime.Now.AddDays(3) });
//            Add(new WorkPackages { StartTime = DateTime.Now.AddDays(10), EndTime = DateTime.Now.AddDays(30) });
//            Add(new WorkPackages { StartTime = DateTime.Now.AddDays(15), EndTime = DateTime.Now.AddDays(35) });
           
//        }

//        public WorkPackages Add(WorkPackages item)
//        {
//            if (item == null)
//            {
//                throw new ArgumentNullException("item WorkPackages");
//            }

//            item.Id = _nextId++;
//            WorkPackagess.Add(item);
//            return item;
//        }

//        public WorkPackages Get(int id)
//        {
//            return WorkPackagess.Find(p => p.Id == id);
//        }

//        public IEnumerable<WorkPackages> GetAll()
//        {
//            return WorkPackagess;
//        }

//        public void Remove(int id)
//        {
//            WorkPackagess.RemoveAll(p => p.Id == id);
//        }

//        public bool Update(WorkPackages item)
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