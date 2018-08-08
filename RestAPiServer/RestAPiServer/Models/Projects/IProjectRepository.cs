using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPiServer.Models.Projects
{
    interface IProjectRepository
    {
        IEnumerable<Project> GetAll();
        Project Add(Project item);
        void Remove(int id);
        bool Update(Project item);
    }
}
