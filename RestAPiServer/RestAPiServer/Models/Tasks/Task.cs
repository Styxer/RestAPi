using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Projects
{
    public class Task : Base.BaseModel
    {       
        public string TaskName { get; set; }       
        public Project project { get; set; }

    }
}