using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Projects
{
    public class WorkPackages : Base.BaseModel
    {       
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}