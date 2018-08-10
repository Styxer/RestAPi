using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Projects
{
    public class Customers : Base.BaseModel
    {        
        public string CustName { get; set; } = String.Empty;
      
    }
}