using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Projects
{
    public class WorkPackage : Base.BaseModel
    {       
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Employe employee { get; set; }
        public Task task { get; set; }

    }
}