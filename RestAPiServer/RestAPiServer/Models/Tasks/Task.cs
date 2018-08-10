using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Projects
{
    public class Task : Base.BaseModel
    {       
        public string taskName { get; set; }
        public int MyProperty { get; set; }
        public Project project { get; set; }

    }
}